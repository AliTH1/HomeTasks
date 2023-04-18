using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceStatic.Models
{
    internal class Gallery
    {

        Car[] cars = new Car[0];


        public void AddCar(Car car)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[Car.Id-1] = car;
        }

        public void ShowAllCars()
        {
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }

        public Car[] GetAllCars()
        {
            return cars;
        }

        public Car FindCarById(int id)
        {
            return cars[id];
        }

        public Car FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Speed > minSpeed && cars[i].Speed < maxSpeed)
                {
                    return cars[i];
                }
            }
            return null;
        }


    }
}
