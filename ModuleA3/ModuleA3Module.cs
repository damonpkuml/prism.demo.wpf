using System;
using System.Collections.Generic;
using System.Text;
using ModuleA3.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA3 {
    public class ModuleA3Module : IModule {
        public void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        public void OnInitialized(IContainerProvider containerProvider) {
            var regionManger = containerProvider.Resolve<IRegionManager>();
            regionManger.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }
    }
}
