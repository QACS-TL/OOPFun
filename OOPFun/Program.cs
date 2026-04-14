// See https://aka.ms/new-console-template for more information
using OOPFun;

Animal ani1 = new Animal();
Animal ani2 = new Animal();

ani1.name = "Janet";
ani1.colour = "Purple";
ani1.limbCount = 6;

ani2.name = "Cindy";
ani2.colour = "Green";
ani2.limbCount = 8;
ani2.health = 80;

Console.WriteLine(ani1.Move(10, "down"));
Console.WriteLine(ani2.Move(15));

Console.WriteLine(ani1.Eat("biscuits"));
Console.WriteLine(ani2.Eat("cake"));
