using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Prism.Ioc;
using Prism.Regions;

namespace ActivationDeactivation.Views {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private IContainerExtension _container;
        private IRegionManager _regionManager;
        private IRegion _region;

        private ViewA _viewA;
        private ViewB _viewB;

        public MainWindow(IContainerExtension container, IRegionManager regionManager) {
            InitializeComponent();

            _container = container;
            _regionManager = regionManager;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            _viewA = _container.Resolve<ViewA>();
            _viewB = _container.Resolve<ViewB>();

            _region = _regionManager.Regions["ContentRegion"];

            _region.Add(_viewA);
            _region.Add(_viewB);
        }

        private void Btn1_OnClick(object sender, RoutedEventArgs e) {
            _region.Activate(_viewA);
        }
        private void Btn2_OnClick(object sender, RoutedEventArgs e) {
            _region.Deactivate(_viewA);
        }
        private void Btn3_OnClick(object sender, RoutedEventArgs e) {
            _region.Activate(_viewB);
        }
        private void Btn4_OnClick(object sender, RoutedEventArgs e) {
            _region.Deactivate(_viewB);
        }
    }
}
