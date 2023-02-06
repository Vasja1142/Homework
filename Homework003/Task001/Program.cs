//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.Write("Введите пятизначное число: ");
int ABCDE = int.Parse(Console.ReadLine()!);

ABCDE = Math.Abs(ABCDE);

if (ABCDE >= 10000 && ABCDE < 100000)
{
    int A = ABCDE / 10000;
    int B = (ABCDE - A * 10000) / 1000;
    int DE = ABCDE % 100;
    if (B * 10 + A == DE)
    {
        Console.Write("Данное число является палиндропом");
    }
    else
    {
        Console.Write("Данное число не является палиндропом");
    }
}
else
{
    Console.Write("Данное число не является пятизначным");
}