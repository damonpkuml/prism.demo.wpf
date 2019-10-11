using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace ViewModelLocator2.Views {
    public class MainWindowViewModel : BindableBase {
        private string _title= "自定义命名协定ViewModelLocator";

        public string Title {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

    }
}
