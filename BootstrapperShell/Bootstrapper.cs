using BootstrapperShell.Views;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Unity;

namespace BootstrapperShell {
    class Bootstrapper : UnityBootstrapper {
        protected override DependencyObject CreateShell() {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell() {
            Application.Current.MainWindow.Show();
        }
    }
}
