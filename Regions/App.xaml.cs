﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using Regions.Views;

namespace Regions{
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