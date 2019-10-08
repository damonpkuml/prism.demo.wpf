using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using Prism.Regions;

namespace CustomRegions{
    public class StackPanelRegionAdapter : RegionAdapterBase<StackPanel>{
        public StackPanelRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory){
        }

        protected override void Adapt(IRegion region, StackPanel regionTarget){
            region.Views.CollectionChanged += (s, e) => {
                if (e.Action == NotifyCollectionChangedAction.Add){
                    foreach (FrameworkElement eNewItem in e.NewItems){
                        regionTarget.Children.Add(eNewItem);
                    }
                }
            };
        }

        protected override IRegion CreateRegion(){
            return new AllActiveRegion();
        }
    }
}