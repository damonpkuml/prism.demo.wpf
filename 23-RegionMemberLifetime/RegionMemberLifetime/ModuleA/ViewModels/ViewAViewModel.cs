using System;
using Prism.Mvvm;
using Prism.Regions;

namespace ModuleA.ViewModels {
    public class ViewAViewModel : BindableBase, INavigationAware {
        public ViewAViewModel() {

        }

        public bool IsNavigationTarget(NavigationContext navigationContext) {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext) {

        }

        public void OnNavigatedTo(NavigationContext navigationContext) {

        }
    }
}
