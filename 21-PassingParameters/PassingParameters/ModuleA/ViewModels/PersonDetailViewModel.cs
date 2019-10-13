using System;
using System.Collections.Generic;
using System.Text;
using ModuleA.Business;
using Prism.Mvvm;
using Prism.Regions;

namespace ModuleA.ViewModels {
    public class PersonDetailViewModel : BindableBase,INavigationAware {
        private Person _selectedPerson;

        public Person SelectedPerson {
            get { return _selectedPerson; }
            set { SetProperty(ref _selectedPerson, value); }
        }

        public PersonDetailViewModel()
        {
            
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            var parameters = navigationContext.Parameters;
            var person = parameters["person"] as Person;
            if (person!=null)
            {
                SelectedPerson = person;
            }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            var person = navigationContext.Parameters["person"] as Person;
            if (person != null)
            {
                //如果是同一个，则使用原来的视图
                return (SelectedPerson!=null && person.LastName == SelectedPerson.LastName); 
            }
            else return true;

        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}
