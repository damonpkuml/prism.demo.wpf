using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ModulA.Business;
using ModulA.ViewModels;
using Prism.Common;
using Prism.Regions;

namespace ModulA.Views {
    /// <summary>
    /// PersonDetail.xaml 的交互逻辑
    /// </summary>
    public partial class PersonDetail : UserControl {
        public PersonDetail() {
            InitializeComponent();
            RegionContext.GetObservableContext(this).PropertyChanged += PersonDetail_PropertyChanged;
        }

        private void PersonDetail_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
            var obj = (ObservableObject<object>)sender;
            var selectedPerson = (Person)obj.Value;
            (DataContext as PersonDetailViewModel).SelectedPerson = selectedPerson;
        }
    }
}
