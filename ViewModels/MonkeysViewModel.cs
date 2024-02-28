using ShellLessonStep2.Services;
using ShellLessonStep2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellLessonStep2.ViewModels
{
    internal class MonkeysViewModel:ViewModelBase
    {
        private ObservableCollection<Monkeys> monkeys;
        public ObservableCollection<Monkeys> Monkeys
        {
            get
            {
                return this.monkeys;
            }
            set
            {
                this.monkeys = value;
                OnPropertyChanged();
            }
        }




        private AnimalService monkeyService;
        public MonkeysViewModel(AnimalService service)
        {
            this.monkeyService = service;
            monkeys = new ObservableCollection<Monkeys>();
            ReadMonkey();
        }

        private async void ReadMonkey()
        {
            AnimalService service = this.monkeyService;
            List<Monkeys> list = await service.GetMonkeys();
            this.Monkeys = new ObservableCollection<Monkeys>(list);
        }



    }
}
