using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Modules3.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

namespace Modules3 {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication {
        protected override void RegisterTypes(IContainerRegistry containerRegistry) {

        }

        protected override Window CreateShell() {
            return Container.Resolve<MainWindow>();
        }

        protected override IModuleCatalog CreateModuleCatalog() {
            return new DirectoryModuleCatalog() { ModulePath = @".\Modules3" };
        }
    }
}
