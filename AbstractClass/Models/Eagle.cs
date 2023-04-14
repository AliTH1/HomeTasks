using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Models
{
    internal class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat like an eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly like a bird");
        }

        public override void See()
        {
            Console.WriteLine("See like a Eagle");
        }
    }
}
