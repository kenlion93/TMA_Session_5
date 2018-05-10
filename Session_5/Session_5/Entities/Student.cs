using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5.Entities
{
    public class Student : Human
    {
        public string Id { get; set;}
        public double Avg { get; set; }

        public Student() { }

        public Student(string id, string name, string gender, double avg) : base(name, gender)
        {
            this.Id = id;
            this.Avg = avg;
        }

        public void display()
        {
            Console.WriteLine("ID: " + this.Id);
            Console.WriteLine("Avg: " + this.Avg);
            base.Display();
        }
    }
}
