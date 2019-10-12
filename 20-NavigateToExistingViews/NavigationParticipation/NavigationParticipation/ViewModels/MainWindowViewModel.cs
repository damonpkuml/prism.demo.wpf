using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace NavigationParticipation.ViewModels {
    public class MainWindowViewModel : BindableBase {
        private IRegionManager _regionManager;
        public DelegateCommand<string> NavigateCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager) {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private void Navigate(string navigatePath) {
            _regionManager.RequestNavigate("ContentRegion", navigatePath,NavigateComplete);
        }

        /// <summary>
        /// 导航完成回调
        /// </summary>
        /// <param name="result"></param>
        private void NavigateComplete(NavigationResult result)
        {
            
        }
    }
}
