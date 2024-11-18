using Messenger_app.Model;
using System.Collections.ObjectModel;
using System;

namespace Messenger_app.View.ViewModel
{
    internal class MainPageViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }
        public Person NewPerson { get; set; }

        public MainPageViewModel()
        {
            Persons = new ObservableCollection<Person>
            {
                new Person { Id = 1, Name = "Jan Postulski", Description = "Kawa to moje życie", ImageLink = "osoba1.jpg" },
                new Person { Id = 2, Name = "Alicja Bystra", Description = "<brak opisu>", ImageLink = "osoba2.jpg"},
                new Person { Id = 3, Name = "Adrianna Nowak", Description = "Przyroda to ciężki przedmiot", ImageLink = "osoba3.jpg"},
                new Person { Id = 4, Name = "Grażyna Łuk", Description = "Życie mnie mnie", ImageLink = "osoba4.jpg" },
                new Person { Id = 5, Name = "Krystian Błąd", Description = "Life is fun", ImageLink = "osoba5.jpg" },
                new Person { Id = 6, Name = "Adrian Jańczyk", Description = "Droga do sukcesu nie jest prosta", ImageLink = "osoba6.jpg"},
                new Person { Id = 7, Name = "Michaś Kowalczyk", Description = "Gry to moja specjalność", ImageLink = "osoba7.jpg" }
            };

            NewPerson = new Person();
        }
    }
}
