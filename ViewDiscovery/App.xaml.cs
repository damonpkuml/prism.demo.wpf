using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using ViewDiscovery.Views;

namespace ViewDiscovery{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication{
        protected override void RegisterTypes(IContainerRegistry containerRegistry){
            
        }

        protected override Window CreateShell(){
            return Container.Resolve<MainWindow>();
        }
    }
}