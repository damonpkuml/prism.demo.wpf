using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace ViewModelLocator.ViewModels {
    public class MainWindowViewModel : BindableBase {
        private string _title = "ViewModelLocator自动触发";

        public string Title {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


    }
}
