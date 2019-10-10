using System.Windows;
using Modules2.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

namespace Modules2 {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
    
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        /// <summary>
        /// 注意和 通过配置文件加载模块的区别
        /// </summary>
        /// <param name="moduleCatalog"></param>
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleA2.ModuleA2Module>();
        }
    }
}
