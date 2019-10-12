using System;
using System.Collections.Generic;
using System.Text;
using ModuleB.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleB {
    public class ModuleBModule : IModule {
        public void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        public void OnInitialized(IContainerProvider containerProvider) {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            var region = regionManager.Regions["RightRegion"];
            var view = containerProvider.Resolve<MessageListView>();
            region.Add(view);
        }
    }
}
