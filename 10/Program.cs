// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int result = (num - num / 100 * 100 - num % 10) / 10;
System.Console.WriteLine(result);