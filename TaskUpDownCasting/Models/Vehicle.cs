using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskUpDownCasting.Models
{
    internal abstract class Vehicle
    {
        public double Price { get; set; }

        public abstract void Drive();
    }
}
