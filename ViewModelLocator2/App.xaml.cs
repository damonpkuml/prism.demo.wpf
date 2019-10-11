using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using ViewModelLocator2.Views;

namespace ViewModelLocator2 {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication {
        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        protected override Window CreateShell() {
            return Container.Resolve<MainWindow>();
        }

        /// <summary>
        /// 命名协定
        /// </summary>
        protected override void ConfigureViewModelLocator() {
            base.ConfigureViewModelLocator();
            //指定ViewModel在和对应的View在同一个命名空间下，只是后缀加上ViewModel
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) => {
                var viewName = viewType.FullName;
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                var viewModelName = $"{viewName}ViewModel,{viewAssemblyName}";
                return Type.GetType(viewModelName);
            });
        }
    }
}
