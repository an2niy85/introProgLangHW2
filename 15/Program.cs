// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите цифру дня недели");
int num = int.Parse(Console.ReadLine());
if (num < 1 || num > 7)
    System.Console.WriteLine("Такого дня недели нет");
else if (num >= 6 && num <= 7)
    System.Console.WriteLine("Этот день выходной");
else
    System.Console.WriteLine("Этот день не выходной");
//int result = (num - num / 100 * 100 - num % 10) / 10;
//System.Console.WriteLine(result);