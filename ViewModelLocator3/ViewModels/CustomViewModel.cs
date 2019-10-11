using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace ViewModelLocator3.ViewModels {
    public class CustomViewModel : BindableBase {
        private string _title="对特殊视图创建指定的ViewModel";

        public string Title {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
