/*
Задача 25: Напишите цикл,
который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

a­­^ = (a*a*a*...*a) - n раз
*/

Console.WriteLine("Введите число А, которое является основание степени");
int numberA = int.Parse(Console.ReadLine() ??"");
Console.WriteLine("Введите число В, которое является степенью, в которое возводится основание степени");
int numberB = int.Parse(Console.ReadLine() ??"");
Console.WriteLine();
double result = Math.Pow(numberA, numberB);
Console.WriteLine($"{result}");