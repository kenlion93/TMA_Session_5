using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5.Entities
{
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meo meo meo");
        }

        public override void Move()
        {
            Console.WriteLine("Con meo chay");
        }
    }
}
