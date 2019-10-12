using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace BasicRegionNavigation.ViewModels {
    public class MainWindowViewModel : BindableBase {
        private IRegionManager _regionManager;
        public DelegateCommand<string> NavigateCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager) {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string obj) {
            _regionManager.RequestNavigate("ContentRegion", obj);
        }
    }
}
