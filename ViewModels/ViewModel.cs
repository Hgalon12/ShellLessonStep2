using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellLessonStep2.ViewModels
{
    public class ViewModel
    {
        public ViewModel() 
        {
            HelpCommand = new Command(OnHelpClicked);
        }
        public Command HelpCommand { get; set; }
        private void OnHelpClicked()
        {
            Shell.Current.DisplayAlert("Help", " this is help  ", "Ok");
        }

    }
}
