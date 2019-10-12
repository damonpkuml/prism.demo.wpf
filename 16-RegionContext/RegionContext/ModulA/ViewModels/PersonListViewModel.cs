using System.Collections.ObjectModel;
using ModulA.Business;
using Prism.Mvvm;

namespace ModulA.ViewModels {
    public class PersonListViewModel : BindableBase {
        private ObservableCollection<Person> _people;

        public ObservableCollection<Person> People {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }

        public PersonListViewModel() {
            InitPeople();
        }

        private void InitPeople() {
            People = new ObservableCollection<Person>();
            for (int i = 0; i < 10; i++) {
                var person = new Person();
                person.FirstName = $"First {i}";
                person.LastName = $"Last {i}";
                person.Age = i;

                People.Add(person);
            }
        }
    }
}
