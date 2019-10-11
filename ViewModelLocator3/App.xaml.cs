using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using ViewModelLocator3.ViewModels;
using ViewModelLocator3.Views;

namespace ViewModelLocator3 {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication {
        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        protected override Window CreateShell() {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureServiceLocator() {
            base.ConfigureServiceLocator();
            ViewModelLocationProvider.Register<MainWindow, CustomViewModel>();
        }
    }
}
