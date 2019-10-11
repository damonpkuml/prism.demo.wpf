using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;
using UsingCompositeCommands.Core;

namespace UsingCompositeCommands.ViewModels {
    public class MainWindowViewModel : BindableBase {
        private string _title = "组合命令的使用";

        public string Title {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private IApplicationCommands _applicationCommands;

        public IApplicationCommands ApplicationCommands {
            get { return _applicationCommands; }
            set { SetProperty(ref _applicationCommands, value); }
        }


        public MainWindowViewModel(IApplicationCommands applicationCommands) {
            ApplicationCommands = applicationCommands;
        }
    }
}
