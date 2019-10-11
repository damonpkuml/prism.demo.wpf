using System;
using System.Collections.Generic;
using System.Text;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using UsingCompositeCommands2.Core;

namespace ModuleA6.ViewModels {
    /// <summary>
    /// IActiveAware 激活项处理
    /// </summary>
    public class TabViewModel : BindableBase, IActiveAware {
        private string _title;

        public string Title {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _canExecute = true;

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

        public TabViewModel(IApplicationCommands applicationCommands) {
            _applicationCommands = applicationCommands;
            UpdateCommand = new DelegateCommand(Update).ObservesCanExecute(() => CanExecute);
            _applicationCommands.CompositeCommand.RegisterCommand(UpdateCommand);
        }

        private void Update() {
            OutputText = $"tab:{Title}, Now Time :{DateTime.Now}";
        }

        private bool _isActive;

        public bool IsActive {
            get { return _isActive; }
            set {
                //SetProperty(ref _isActive, value);
                _isActive = value;
                OnAcitvateChanged();
            }

        }

        private void OnAcitvateChanged() {
            UpdateCommand.IsActive = IsActive;
            IsActiveChanged?.Invoke(this, new EventArgs());
        }

        public event EventHandler IsActiveChanged;
    }
}
