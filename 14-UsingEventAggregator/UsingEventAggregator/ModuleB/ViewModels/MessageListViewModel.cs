using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Prism.Events;
using Prism.Mvvm;
using UsingEventAggregator.Core;

namespace ModuleB.ViewModels {
    public class MessageListViewModel : BindableBase {
        private ObservableCollection<string> _messages;

        public ObservableCollection<string> Messages {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }

        private IEventAggregator _eventAggregator;

        public MessageListViewModel(IEventAggregator eventAggregator) {
            _eventAggregator = eventAggregator;
            Messages = new ObservableCollection<string>();
            _eventAggregator.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);
        }

        private void MessageReceived(string obj) {
            Messages.Add(obj);
        }
    }
}
