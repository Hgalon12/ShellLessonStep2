using ShellLessonStep2.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellLessonStep2.Services;

namespace ShellLessonStep2.ViewModels
{
    internal class CatsViewModel:ViewModelBase
    {

        private ObservableCollection<Cats> cats;
        public ObservableCollection<Cats> Cats
        {
            get
            {
                return this.cats;
            }
            set
            {
                this.cats= value;
                OnPropertyChanged();
            }
        }
        private AnimalService catsService;
        public CatsViewModel(AnimalService service)
        {
            this.catsService = service;
            cats = new ObservableCollection<Cats>();
            ReadCats();
        }

        private async void ReadCats()
        {
            AnimalService service = this.catsService;
            List<Monkeys> list = await service.GetCats();
            this.Cats = new ObservableCollection<Cats>(list);
        }



    }
}
