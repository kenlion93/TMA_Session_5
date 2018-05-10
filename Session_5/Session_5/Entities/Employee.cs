using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5.Entities
{
    class Employee : Human
    {
        public string Id { get; set; }
        public double Salary {get; set;}
        public int Exp {get; set;}

        public Employee() { }

        public Employee(string id, string name, string gender, double salary, int exp):base(name, gender)
        {
            this.Id = id;
            this.Salary = salary;
            this.Exp = exp;
        }

        public void display_emp()
        {
            Console.WriteLine("\nID: " + this.Id);
            Console.WriteLine("Salary: " + this.Salary);
            Console.WriteLine("Experience: " + this.Exp);
            base.Display();
        }
    }
}
