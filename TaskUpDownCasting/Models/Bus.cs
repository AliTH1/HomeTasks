using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskUpDownCasting.Models
{
    internal class Bus : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Drive bus");
        }
    }
}
