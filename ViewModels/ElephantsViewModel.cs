using ShellLessonStep2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellLessonStep2.ViewModels
{
    internal class ElephantsViewModel:ViewModelBase
    {
        private ObservableCollection<Elephants> elephants;
        public ObservableCollection<Elephants> Elephants
        {
            get
            {
                return this.elephants;
            }
            set
            {
                this.elephants = value;
                OnPropertyChanged();
            }
        }
    }
}
