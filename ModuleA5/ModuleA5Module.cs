using System;
using System.Collections.Generic;
using System.Text;
using ModuleA5.ViewModels;
using ModuleA5.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA5 {
    public class ModuleA5Module : IModule {
        public void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        public void OnInitialized(IContainerProvider containerProvider) {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            var iRegion = regionManager.Regions["MainContentRegion"];

            var tabA = containerProvider.Resolve<TabView>();
            SetTabTitle(tabA, "TabA");
            iRegion.Add(tabA);

            var tabB = containerProvider.Resolve<TabView>();
            SetTabTitle(tabB, "TabB");
            iRegion.Add(tabB); 
           
            var tabC = containerProvider.Resolve<TabView>();
            SetTabTitle(tabC, "TabC");
            iRegion.Add(tabC);
        }

        private void SetTabTitle(TabView tabView, string title) {
            (tabView.DataContext as TabViewModel).Title = title;
        }
    }
}
