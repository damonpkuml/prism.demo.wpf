using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Mvvm;
using UsingCompositeCommands.Core;

namespace ModuleA5.ViewModels {
    public class TabViewModel : BindableBase {
        private string _title;

        public string Title {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _canExecute=true;

        public bool CanExecute {
            get { return _canExecute; }
            set { SetProperty(ref _canExecute, value); }
        }

        private string _outputText;

        public string OutputText {
            get { return _outputText; }
            set { SetProperty(ref _outputText, value); }
        }


        public DelegateCommand UpdateCommand { get; private set; }
        private IApplicationCommands _applicationCommands;

        public TabViewModel(IApplicationCommands applicationCommands)
        {
            _applicationCommands = applicationCommands;
            UpdateCommand = new DelegateCommand(Update).ObservesCanExecute(() => CanExecute);
            _applicationCommands.CompositeCommand.RegisterCommand(UpdateCommand);
        }

        private void Update() {
            OutputText = $"tab:{Title}, Now Time :{DateTime.Now}";
        }
    }
}
