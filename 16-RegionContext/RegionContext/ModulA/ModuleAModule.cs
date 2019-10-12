using System;
using System.Collections.Generic;
using System.Text;
using ModulA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModulA {
    public class ModuleAModule : IModule {
        public void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        public void OnInitialized(IContainerProvider containerProvider) {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(PersonList));
            regionManager.RegisterViewWithRegion("PersonDetailRegion", typeof(PersonDetail));
        }
    }
}
