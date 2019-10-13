using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;

namespace UsingPopupWindowAction.ViewModels {
    public class MainWindowViewModel : BindableBase {
        private string _title = "弹出模块窗口";

        public string Title {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public InteractionRequest<INotification> NotificationRequest { get; private set; }
        public DelegateCommand ShowPopupCommand { get; private set; }
        public MainWindowViewModel() {
            NotificationRequest = new InteractionRequest<INotification>();
            ShowPopupCommand = new DelegateCommand(ShowPopup);
        }

        private void ShowPopup() {
            NotificationRequest.Raise(new Notification() { Content = "通知消息", Title = "通知" }, r => Title = "通知完成");
        }
    }
}
