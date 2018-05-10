using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5.Entities
{
    public class Human
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public Human() { }

        public Human(string name, string gender)
        {
            this.Name = name;
            this.Gender = gender;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Gender: " + this.Gender);
        }
    }
}
