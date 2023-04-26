using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskUpDownCasting.Models
{
    internal class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Drive car");
        }

        public static bool operator > (Car price1, Car price2) =>
            price1.Price > price2.Price;
        public static bool operator < (Car price1, Car price2) =>
            price1.Price < price2.Price;
    }
}
