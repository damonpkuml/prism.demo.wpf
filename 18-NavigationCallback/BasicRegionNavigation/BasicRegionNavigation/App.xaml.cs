using System.Windows;
using BasicRegionNavigation.Views;
using ModuleA;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

namespace BasicRegionNavigation {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication {
        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        protected override Window CreateShell() {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog) {
            moduleCatalog.AddModule<ModuleAModule>();
        }
    }
}
