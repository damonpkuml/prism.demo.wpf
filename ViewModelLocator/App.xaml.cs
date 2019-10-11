using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using ViewModelLocator.Views;

namespace ViewModelLocator {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication {
        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
            //注册类型到容器的地方
        }

        protected override Window CreateShell() {
            return Container.Resolve<MainWindow>();
        }
    }
}
