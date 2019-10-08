using System.Windows;
using System.Windows.Controls;
using CustomRegions.Views;
using Prism.Ioc;
using Prism.Regions;
using Prism.Unity;

namespace CustomRegions{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication{
        protected override void RegisterTypes(IContainerRegistry containerRegistry){
        }

        protected override Window CreateShell(){
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings){
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(StackPanel),
                Container.Resolve<StackPanelRegionAdapter>());
        }
    }
}