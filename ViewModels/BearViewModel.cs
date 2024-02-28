using ShellLessonStep2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellLessonStep2.ViewModels
{
    internal class BearViewModel:ViewModelBase
    {
        private ObservableCollection<Bears> bears;
        public ObservableCollection<Bears> Bears
        {
            get
            {
                return this.bears;
            }
            set
            {
                this.bears = value;
                OnPropertyChanged();
            }
        }

    }
}
