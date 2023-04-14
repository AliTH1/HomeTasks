using AbstractClass.Models;

Animal eagle = new Eagle();
Animal shark = new Shark();

Animal[] animals = { eagle, shark };

foreach (var animal in animals)
{
    animal.Eat();
    animal.See();
}