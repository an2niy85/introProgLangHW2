// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите любое положительное целое число");
int num = int.Parse(Console.ReadLine());
if (num / 100 != 0)
    System.Console.WriteLine((num - num / 1000 * 1000 - num % 100) / 100);
else
    System.Console.WriteLine("третьей цифры нет");
//int result = (num - num / 100 * 100 - num % 10) / 10;
//System.Console.WriteLine(result);