using InterfaceStatic.Models;

Car audi = new Car();
audi.Name = "Audi";
audi.Color = "Red";
audi.Speed = 50;

Car bmw = new Car();
bmw.Name = "BMW";
bmw.Color = "Black";
bmw.Speed = 200;

Gallery gallery = new Gallery();

gallery.AddCar(audi);

gallery.AddCar(bmw);

Console.WriteLine(gallery.FindCarById(0));

Console.WriteLine(gallery.FindCarById(1));

Console.WriteLine(gallery.FindCarsBySpeedInterval(100, 250));