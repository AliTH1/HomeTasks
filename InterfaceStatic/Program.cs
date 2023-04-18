using InterfaceStatic.Models;

Car audi = new Car();
audi.Name = "Audi";
audi.Color = "Red";
audi.Speed = 100;

Car bmw = new Car();
bmw.Name = "BMW";
bmw.Color = "Black";
bmw.Speed = 200;

Gallery gallery = new Gallery();

gallery.AddCar(audi);

gallery.AddCar(bmw);