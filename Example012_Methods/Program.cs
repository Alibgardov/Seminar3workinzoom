﻿//Вид 4 
// string Method4(int count, string text)
// { 
    
//     string result = String.Empty;
//     for (int i = 0;i < count;i++ )
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "asd");
// Console.WriteLine(res);

//Цикл for таблица умножения 
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }









//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//       +"ежели бы вас послали вместо нашего милого Винценгероде,"
//       +"вы бы взяли приступом согласие прусского короля."
//       +"Вы так красноречивы. Вы дадите мне чаю?";

// //string s = "qwerty"
// //            012345
// //s[3] //  r 

// string Replase(string text, char oldValue, char newValue)
// {
// string result = String.Empty;
// int length = text.Length;
// for (int i = 0; i < length; i++)
// {
//     if(text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text[i]}";
// }
// return result;
// }
// string newText = Replase(text, "k","K");
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replase(newText, " ","-");
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replase(newText, "c","C");
// Console.WriteLine(newText);
// Console.WriteLine();

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PtintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]}");
}
Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PtintArray(arr);
SelectionSort(arr);
PtintArray(arr);

