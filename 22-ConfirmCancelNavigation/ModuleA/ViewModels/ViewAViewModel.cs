using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Windows;

namespace ModuleA.ViewModels {
    public class ViewAViewModel : BindableBase, IConfirmNavigationRequest {

        private int _pageCount;

        public int PageCount {
            get { return _pageCount; }
            set { SetProperty(ref _pageCount, value); }
        }

        public ViewAViewModel() {

        }


        public void OnNavigatedTo(NavigationContext navigationContext) {
            PageCount++;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext) {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext) {

        }

        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback) {
            var result = true;
            if (MessageBox.Show("确定导航？", "提醒", MessageBoxButton.YesNo) == MessageBoxResult.No)
                result = false;
            continuationCallback(result);
        }
    }
}
