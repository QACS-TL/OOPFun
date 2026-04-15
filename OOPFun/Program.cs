// See https://aka.ms/new-console-template for more information
using OOPFun;

Animal ani1 = new Animal("Janet", "Purple", -1);
Animal ani2 = new Animal();
Animal ani3 = new Animal() { Name = "Mandy", Colour = "Pink", LimbCount = 3, Health = 50 };
Animal ani4 = null;

//ani1.Name = "Janet";
//ani1.Colour = "Purple";
//ani1.limbCount = -1
//ani1.SetLimbCount(-1);
//ani1.LimbCount = -1;

ani2.Name = "Cindy";
ani2.Colour = "Green";
ani2.LimbCount =800;
ani2.Health = 80;

//Console.WriteLine(ani2.limbCount);
//Console.WriteLine(ani2.GetLimbCount());
Console.WriteLine(ani2.LimbCount);

Console.WriteLine(ani1.Move(10, "down"));
Console.WriteLine(ani2.Move(15));

Console.WriteLine(ani1.Eat("biscuits"));
Console.WriteLine(ani2.Eat("cake"));

if (ani4 != null)
{
    Console.WriteLine(ani4.Eat("Sweets"));
}

//Console.WriteLine($"There are {Animal.Counter} animals created so far!");
Console.WriteLine(Animal.GetCounter());

Console.WriteLine(Utilities.Add(5, 10));

List<Animal> zoo = new List<Animal>();
zoo.Add(ani1);
zoo.Add(ani2);
zoo.Add(ani3);

foreach(Animal animal in zoo)
{
    Console.WriteLine(animal.Eat("iced buns"));
}

for(int i=0; i < zoo.Count; i++)
{
    Console.WriteLine(zoo[i].Eat("ice cream"));
}


List<Animal> animalsWithMoreThanOneLeg = zoo.Where(ani => ani.LimbCount > 1).ToList();
Console.WriteLine("Animals with more than one leg:");
foreach (Animal animal in animalsWithMoreThanOneLeg)
{
    Console.WriteLine($"{animal.Name} has {animal.LimbCount} limbs");
}

zoo.Sort((a, b) => a.Name.CompareTo(b.Name));
Console.WriteLine("Animals sorted by name:");
foreach (Animal animal in zoo)
{
    Console.WriteLine($"{animal.Name} is {animal.Colour} and has {animal.LimbCount} limbs.");
}

zoo.Sort((a, b) => a.Colour.CompareTo(b.Colour));
Console.WriteLine("Animals sorted by colour:");
foreach (Animal animal in zoo)
{
    Console.WriteLine($"{animal.Name} is {animal.Colour} and has {animal.LimbCount} limbs.");
}


zoo.Sort((a, b) => a.LimbCount.CompareTo(b.LimbCount));
Console.WriteLine("Animals sorted by limb count:");
foreach (Animal animal in zoo)
{
    Console.WriteLine($"{animal.Name} is {animal.Colour} and has {animal.LimbCount} limbs.");
}


