/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]        

6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/


Console.WriteLine("Введите массив из 8 чисел");
string input = Console.ReadLine() ??"";
string[] temp = input.Split(' ');

int[] resultArray = new int[temp.Length];
for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = int.Parse(temp[i]);
}
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write($"{resultArray[i]}, ");
}