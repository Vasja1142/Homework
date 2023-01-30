//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int x = 100;

if (num / 100 > 0)
{
    while (num / x > 10)
    {
       x = x * 10; 
    }
    
    x = x / 10;
    int y = num % x;
    int result = y / (x / 10);
    Console.Write(result);
}
else
{
    Console.Write("В данном числе нет третьей цифры");
}