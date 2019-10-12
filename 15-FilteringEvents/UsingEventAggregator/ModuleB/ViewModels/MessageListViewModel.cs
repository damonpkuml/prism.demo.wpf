using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Prism.Events;
using Prism.Mvvm;
using UsingEventAggregator.Core;

namespace ModuleB.ViewModels {
    public class MessageListViewModel : BindableBase {
        private IEventAggregator _eventAggregator;

        //如果使用List，集合添加等变更不会通知UI
        private ObservableCollection<Message> _messages;

        public ObservableCollection<Message> Messages {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }

        public MessageListViewModel(IEventAggregator eventAggregator) {
            _eventAggregator = eventAggregator;
            Messages = new ObservableCollection<Message>();
            _eventAggregator.GetEvent<MessageSendEvent>().Subscribe(MessageReceived,
                ThreadOption.PublisherThread,
                false,
                (filter) => filter.Body.ToUpper().Contains("CHINA")); //只订阅包含China的消息
        }

        private void MessageReceived(Message obj) {
            Messages.Add(obj);
        }
    }
}
