using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5.Entities
{
    public class Fish : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("bup bup bup");
        }

        public override void Move()
        {
            Console.WriteLine("Con ca boi");
        }
    }
}
