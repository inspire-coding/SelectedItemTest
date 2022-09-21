using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Model;

namespace WPF.ViewModel
{
    public class PersonViewModel: ViewModelBase
    {
        private ObservableCollection<PersonClass> _people = new ObservableCollection<PersonClass>();
        public ObservableCollection<PersonClass> People
        {
            get { return _people; }
            set 
            { 
                _people = value;
                OnPropertyChanged(nameof(People));
            }
        }

        private PersonClass _selectedPerson;
        public PersonClass SelectedPerson
        {
            get { return _selectedPerson; }
            set 
            {
                value.Name = "Bogi";
                _selectedPerson = value;
                OnPropertyChanged(nameof(SelectedPerson));
                OnPropertyChanged(nameof(People));
            }
        }

        private ObservableCollection<string> _texts = new ObservableCollection<string>();
        public ObservableCollection<string> Texts
        {
            get { return _texts; }
            set 
            { 
                _texts = value;
                OnPropertyChanged(nameof(Texts));
            }
        }

        private string _selectedText;
        public string SelectedText
        {
            get { return _selectedText; }
            set
            {
                value = "Bogi";
                _selectedText = value;
                OnPropertyChanged(nameof(SelectedText));
            }
        }

        private ObservableCollection<PersonRecord> _peopleRecord = new ObservableCollection<PersonRecord>();
        public ObservableCollection<PersonRecord> PeopleRecord
        {
            get { return _peopleRecord; }
            set 
            { 
                _peopleRecord = value;
            }
        }

        private PersonRecord _selectedPersonRecord;
        public PersonRecord SelectedPersonRecord
        {
            get { return _selectedPersonRecord; }
            set
            {
                value.Name = "Bogi";
                _selectedPersonRecord = value;
            }
        }





        public PersonViewModel()
        {
            this.PopulateLists();
        }

        private void PopulateLists()
        {
            this.People.Add(new PersonClass { Name = "Dávid", Age = 0.83d });
            this.People.Add(new PersonClass { Name = "Viki", Age = 37 });
            this.People.Add(new PersonClass { Name = "Peti", Age = 34 });

            this.Texts.Add("Dávid");
            this.Texts.Add("Viki");
            this.Texts.Add("Peti");

            this.PeopleRecord.Add(new PersonRecord { Name = "Dávid", Age = 0.83d });
            this.PeopleRecord.Add(new PersonRecord { Name = "Viki", Age = 37 });
            this.PeopleRecord.Add(new PersonRecord { Name = "Peti", Age = 34 });
        }
    }
}
