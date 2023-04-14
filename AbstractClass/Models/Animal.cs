using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Models
{
    internal abstract class Animal
    {
        public abstract void Eat();

        public virtual void See()
        {
            Console.WriteLine("See as animal");
        }
    }
}
