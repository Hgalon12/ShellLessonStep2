using ShellLessonStep2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellLessonStep2.ViewModels
{
    internal class DogsViewModel:ViewModelBase
    {
        private ObservableCollection<Dogs> dogs;
        public ObservableCollection<Dogs> Dogs
        {
            get
            {
                return this.dogs;
            }
            set
            {
                this.dogs = value;
                OnPropertyChanged();
            }
        }

    }
}
