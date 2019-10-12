using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using UsingEventAggregator.Core;

namespace ModuleA.ViewModels {
    public class MessageViewModel : BindableBase {
        private string _message = "要发送的消息";

        public string Message {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public DelegateCommand SendCommand { get; private set; }

        private IEventAggregator _eventAggregator;

        public MessageViewModel(IEventAggregator eventAggregator) {
            _eventAggregator = eventAggregator;
            SendCommand = new DelegateCommand(Send);
        }

        private void Send() {
            _eventAggregator.GetEvent<MessageSentEvent>().Publish(Message);
        }
    }
}
