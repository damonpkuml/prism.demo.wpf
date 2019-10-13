using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ModuleA.Business;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace ModuleA.ViewModels {
    public class PersonListViewModel : BindableBase {
        private IRegionManager _regionManager;
        private ObservableCollection<Person> _people;

        public ObservableCollection<Person> People {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }

        public DelegateCommand<Person> PersonSelectedCommand { get; private set; }

        public PersonListViewModel(IRegionManager regionManager) {
            _regionManager = regionManager;
            InitPeople();
            PersonSelectedCommand = new DelegateCommand<Person>(PersonSelected);
        }

        private void PersonSelected(Person selectedPerson) {
            var naviParameters=new NavigationParameters();
            naviParameters.Add("person",selectedPerson);           
            _regionManager.RequestNavigate("PersonDetailRegion","PersonDetail",naviParameters);
        }

        private void InitPeople() {
            People = new ObservableCollection<Person>();
            for (int i = 0; i < 8; i++) {
                var person = new Person();
                person.FirstName = $"Fist {i}";
                person.LastName = $"Last {i}";
                person.Age = i;
                People.Add(person);
            }
        }
    }
}
