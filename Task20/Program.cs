
// Console.Clear();
// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine());
// int i = 1;
// if (n<i)
// {
//     Console.WriteLine("Введено неверное число n");
//     return;
// }
// while (n >= 1 )
// {
//     Console.WriteLine($" {Math.Pow(i,2)}");
//     i++;
    
// }
// Console.WriteLine("");



Console.Clear();
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine()!);
int[] result = new int[N];
for (int i = 1; i <= N; i++)
    result[i - 1] = i * i;

for (int i = 0; i < N; i++)
    Console.Write($"{result[i]}");
Console.WriteLine();
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"{i} в квадрате = {i * i}");
}
int j = 1;
while(j <= N)
{
    Console.WriteLine($"{j} в квадрате = {j * j}");
    j++;
}














// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4