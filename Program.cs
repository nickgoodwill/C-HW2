// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int x = 0;
int res = 0;
Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

if (n > 99 && n < 1000)
{
    x = n / 10;
    res = x % 10;
    Console.Write("Вторая цифра числа: ");
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Введено не корректное число");
}

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
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int n = int.Parse(Console.ReadLine());

if (n > 0 && n < 8)
{
    if (n > 0 && n < 6)
    {
        Console.Write(n);
        Console.WriteLine(" - рабочий день");
    }
    else
    {
        Console.Write(n);
        Console.WriteLine(" - выходной день");
    }
}
else
{
    Console.WriteLine("Это не день недели");
}