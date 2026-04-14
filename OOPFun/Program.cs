// See https://aka.ms/new-console-template for more information
using OOPFun;

Animal ani1 = new Animal();
Animal ani2 = new Animal();

ani1.Name = "Janet";
ani1.Colour = "Purple";
//ani1.limbCount = -1
//ani1.SetLimbCount(-1);
ani1.LimbCount = -1;

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
