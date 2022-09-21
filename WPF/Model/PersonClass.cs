using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.ViewModel;

namespace WPF.Model
{
    public class PersonClass: ViewModelBase
    {
        public string _name;
        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public double Age { get; set; }
    }
}
