using System;
using System.Collections.Generic;
using System.Text;
using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA {
    public class ModuleAModule : IModule {
        public void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        public void OnInitialized(IContainerProvider containerProvider) {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            var region = regionManager.Regions["LeftRegion"];
            var view = containerProvider.Resolve<MessageView>();
            region.Add(view);
        }
    }
}
