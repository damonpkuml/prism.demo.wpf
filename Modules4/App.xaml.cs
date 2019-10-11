using System.Windows;
using ModuleA4;
using Modules4.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

namespace Modules4 {
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
            var moduleType = typeof(ModuleA4Module);
            moduleCatalog.AddModule(new ModuleInfo() {
                ModuleName = moduleType.Name,
                ModuleType = moduleType.AssemblyQualifiedName,
                InitializationMode = InitializationMode.OnDemand
            });
        }
    }
}
