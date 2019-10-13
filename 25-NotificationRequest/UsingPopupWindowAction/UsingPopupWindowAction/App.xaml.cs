﻿using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using UsingPopupWindowAction.Views;

namespace UsingPopupWindowAction {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication {
        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        protected override Window CreateShell() {
            return Container.Resolve<MainWindow>();
        }
    }
}
