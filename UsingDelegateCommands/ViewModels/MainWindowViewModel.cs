using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Mvvm;

namespace UsingDelegateCommands.ViewModels {
    public class MainWindowViewModel : BindableBase {

        private bool _isEnable;

        public bool IsEnable {
            get { return _isEnable; }
            set {
                SetProperty(ref _isEnable, value);
                ExecuteDelegateCommand.RaiseCanExecuteChanged();
            }
        }

        private string _outputText;

        public string OutputText {
            get { return _outputText; }
            set { SetProperty(ref _outputText, value); }
        }




        /// <summary>
        /// 最简单的委托命令
        /// </summary>
        public DelegateCommand ExecuteDelegateCommand { get; private set; }

        /// <summary>
        /// 观察可用属性
        /// </summary>
        public DelegateCommand DelegateCommandObservesProperty { get; private set; }

        /// <summary>
        /// 观察可用委托(上面基础上的封装)
        /// </summary>
        public DelegateCommand DelegateCommandObservesCanExecute { get; private set; }

        /// <summary>
        ///通用带参数的委托命令(最好使用这种方式)
        /// </summary>
        public DelegateCommand<string> DelegateCommandWithParameter { get; private set; }

        public MainWindowViewModel() {
            ExecuteDelegateCommand = new DelegateCommand(Execute, CanExecute);
            DelegateCommandObservesProperty = new DelegateCommand(Execute, CanExecute).ObservesProperty(() => IsEnable);
            DelegateCommandObservesCanExecute=new DelegateCommand(Execute).ObservesCanExecute(()=>IsEnable);
            DelegateCommandWithParameter=new DelegateCommand<string>(ExecuteWithParameter).ObservesCanExecute(()=>IsEnable);
        }

        private void ExecuteWithParameter(string obj)
        {
            OutputText = obj;
        }

        private void Execute() {
            OutputText = $"Time:{DateTime.Now}";
        }

        private bool CanExecute() {
            return _isEnable;
        }
    }
}
