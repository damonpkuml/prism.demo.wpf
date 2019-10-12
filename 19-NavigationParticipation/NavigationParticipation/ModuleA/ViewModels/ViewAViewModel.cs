using Prism.Mvvm;
using Prism.Regions;

namespace ModuleA.ViewModels {
    public class ViewAViewModel : BindableBase, INavigationAware {
        private string _title = "ViewA";

        public string Title {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private int _pageCount;

        public int PageCount {
            get { return _pageCount; }
            set { SetProperty(ref _pageCount, value); }
        }


        public void OnNavigatedTo(NavigationContext navigationContext) {
            PageCount++;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext) {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext) {

        }
    }
}
