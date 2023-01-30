//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);

//num = Math.Abs(num); возможное решение

if (num / 100 > 0 && num / 100 < 10)
{
    int hundreds = num / 100;
    int result = (num - (hundreds * 100) - (num % 10)) / 10;
    Console.Write(result);
}
else if (-num / 100 > 0 && -num / 100 < 10)
{
    int hundreds = -num / 100;
    int result = (-num - (hundreds * 100) - (-num % 10)) / 10;
    Console.Write(result);
}
else
{
    Console.Write("Данное число не является трехзначным");
}