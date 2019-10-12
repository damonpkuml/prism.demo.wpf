using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;
using Prism.Regions;

namespace ModuleA.ViewModels {
    public class ViewBViewModel : BindableBase, INavigationAware {
        private string _title = "ViewB";

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

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            //return true; //返回True则用原来存在的视图实例
            return _pageCount / 5 != 1; //计数为第6次创建一个新的视图实例
        }

        public void OnNavigatedFrom(NavigationContext navigationContext) {
          
        }
    }
}
