using ListView.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListView.ViewModel
{
    class MainPageViewModel
    {
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        public MainPageViewModel()
        {
            for(int i = 1; i<6; i++)
            {
                Person person = new Person();
                person.Name = "Jesse Liberty" + i.ToString();
                person.Address = i.ToString() + " Main STreet";
                person.ImageSource = "man" + i.ToString() + ".jpg";
                People.Add(person);



            }

        }
    }
}
