﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

//int x = 0;
//int res = 0;
//Console.Write("Введите трехзначное число: ");
//int n = int.Parse(Console.ReadLine());

//if (n > 99 && n < 1000)
//{
//    x = n / 10;
//    res = x % 10;
//    Console.Write("Вторая цифра числа: ");
//    Console.WriteLine(res);
//}
//else
//{
//    Console.WriteLine("Введено не корректное число");
//}

// Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int x = 0;
int res = 0;
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n > 99)
{
    x = n / 100;
    res = x % 10;
    Console.Write("Третья цифра числа: ");
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}