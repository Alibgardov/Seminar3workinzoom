Console.Clear();
Console.WriteLine("Введите X первой точки:");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y первой точки:");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите X второй точки:");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y второй точки:");
double y2 = double.Parse(Console.ReadLine());
double s = Math.Sqrt(Math.Pow(x2-x1,2) - Math.Pow(y2-y1,2));
Console.WriteLine($"s={s:f2}");





// 20 Напишите программу,
// которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);