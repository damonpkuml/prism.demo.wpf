using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using UsingEventAggregator.Core;

namespace ModuleA.ViewModels {
    public class MessageViewModel : BindableBase {
        private IEventAggregator _eventAggregator;

        private string _messageToSend="要发送的消息";

        public string MessageToSend {
            get { return _messageToSend; }
            set { SetProperty(ref _messageToSend, value); }
        }

        public DelegateCommand SendCommand { get; private set; }


        public MessageViewModel(IEventAggregator eventAggregator) {
            _eventAggregator = eventAggregator;
            SendCommand = new DelegateCommand(Send);
        }

        private void Send() {
            Message message = new Message() { Body = MessageToSend, DateTime = DateTime.Now };
            _eventAggregator.GetEvent<MessageSendEvent>().Publish(message);
        }
    }
}
