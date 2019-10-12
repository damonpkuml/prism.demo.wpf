using ModulA.Business;
using Prism.Mvvm;

namespace ModulA.ViewModels {
    public class PersonDetailViewModel : BindableBase {
        private Person _selectedPerson;

        public Person SelectedPerson {
            get { return _selectedPerson; }
            set { SetProperty(ref _selectedPerson, value); }
        }

    }
}
