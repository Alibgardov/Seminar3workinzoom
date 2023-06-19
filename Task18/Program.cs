Console.Clear();
Console.Write("Введите a (Номер четверти x y ) : ");
int a = int.Parse(Console.ReadLine()); 
if (a == 1) Console.WriteLine("X>0; Y>0");
else if (a == 2) Console.WriteLine("X<0; Y>0");
else if (a == 3) Console.WriteLine("X<0; Y<0");
else if (a == 4) Console.WriteLine("X>0; Y<0");
else Console.WriteLine("Введён неверный номер четверти");

// **Задача 18:**

// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y)
// // switch (переменная введённая пользователем в консоле) 
// {
// case 1:{
// Console.WriteLine("x>0 y>0");
// break;
// }
// case 2:{
// Console.WriteLine("x<0 y>0");
// break;
// }
// case 3:{
// Console.WriteLine("x<0 y<0");
// break;
// }
// case 4:{
// Console.WriteLine("x>0 y<0");
// break;
// }
// default:{
// Console.WriteLine("Введена неправильная четверть");
// break;
// }
// }