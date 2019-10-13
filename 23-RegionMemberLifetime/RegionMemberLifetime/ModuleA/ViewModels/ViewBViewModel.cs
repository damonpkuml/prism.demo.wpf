using Prism.Mvvm;
using Prism.Regions;

namespace ModuleA.ViewModels {
    public class ViewBViewModel : BindableBase, INavigationAware, IRegionMemberLifetime {
        public ViewBViewModel() {

        }

        public bool IsNavigationTarget(NavigationContext navigationContext) {
            //总是创建新的视图
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext) {

        }

        public void OnNavigatedTo(NavigationContext navigationContext) {

        }

        //false,当视图从激活状态进入到非激活状态时，从区域管理的视图中删除
        public bool KeepAlive {
            get { return false; }
        }
    }
}
