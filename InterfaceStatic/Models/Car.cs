using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    internal class Car
    {
        public Car()
        {
            Id++;
        }

        public static int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
    }
}
