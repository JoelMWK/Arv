global using System.Numerics;

Student s = new Student();
MovingObject o = new MovingObject();
Jedi j = new Jedi();
Sith d = new Sith();

o.Update();
Console.WriteLine($"Name: {s.name}\nAge: {s.age}\nSchool name: {s.school}\n");
Console.WriteLine($"X: {o.pos.X}\nY: {o.pos.Y}\n");

Console.WriteLine($"Name: {j.Name}\nSide: {j.ForceSide}");
Console.WriteLine($"Name: {d.Name}\nSide: {d.ForceSide}");


Console.ReadLine();
