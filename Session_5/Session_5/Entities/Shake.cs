using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5.Entities
{
    public class Shake : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Con ran keu");
        }

        public override void Move()
        {
            Console.WriteLine("con ran truon");
        }
    }
}
