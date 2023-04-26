using TaskUpDownCasting.Models;

//1
Vehicle car = new Car();
Vehicle bus = new Bus();

Car car1 = car as Car;
Bus bus1 = bus as Bus;

if (car1 is Car)
{
    car1.Drive();
}
else
{
    Console.WriteLine("Car downcast didn't happen");
}

if (bus1 is Bus)
{
    bus1.Drive();
}
else
{
    Console.WriteLine("Bus downcast didn't happen");
}


//2
Car car2 = new Car();
car2.Price = 100;

Car car3 = new Car();
car3.Price = 200;

Console.WriteLine(car1 > car2);