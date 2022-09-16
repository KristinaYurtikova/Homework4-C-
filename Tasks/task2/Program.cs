// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;

Console.WriteLine("Введите целое число");
string number = Console.ReadLine()!;

int sum = 0;
foreach (char a in number)
{
    sum += a - '0';
}
Console.WriteLine($"Сумма цифр в числе равна {sum}");





