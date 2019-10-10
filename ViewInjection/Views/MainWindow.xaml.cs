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

namespace ViewInjection.Views {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private IContainerExtension _container;
        private IRegionManager _regionManager;

        public MainWindow(IContainerExtension container, IRegionManager regionManager) {

            InitializeComponent();

            //构造注入
            _container = container;
            _regionManager = regionManager;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var viewA = _container.Resolve<ViewA>();
            var region = _regionManager.Regions["ContentRegion"];
            Console.WriteLine(region.Views.Count());
            region.Add(viewA);  //可以添加多个View到Region
            Console.WriteLine(region.Views.Count());
        }
    }
}
