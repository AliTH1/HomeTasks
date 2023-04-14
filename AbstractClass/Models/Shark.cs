using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Models
{
    internal class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Eat like a Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim like a Shark");
        }

        public override void See()
        {
            Console.WriteLine("See like a Shark");
        }
    }
}
