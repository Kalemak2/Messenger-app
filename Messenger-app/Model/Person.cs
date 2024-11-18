using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Messenger_app.Model
{
    internal class Person 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageLink { get; set; }

        public Person() { }

        public Person(int id, string name, string description, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageLink = image;
        }
    }

  
}
