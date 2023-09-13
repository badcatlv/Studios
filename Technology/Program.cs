// See https://aka.ms/new-console-template for more information
using Technology;

Console.WriteLine("Hello, World!");

Computer computer = new Computer(2, 3, false);
Computer computer1 = new Computer(1, 2, false);

Laptop laptop = new Laptop(1, 2, false, 7);
Console.WriteLine(computer.Id);
Console.WriteLine(computer1.Id);
Console.WriteLine(laptop.Id);
Console.WriteLine(laptop.IsHeavy());