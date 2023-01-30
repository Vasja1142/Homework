//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
//num = -36759

num = Math.Abs(num);
//num = 36759

int x = 10;

if (num / 100 > 0) //true
{
    while (num / x > 100) //true
    {
       x = x * 10; 
    }
    //x = 100

    int y = num % x; //y = 759
    int result = y / (x / 10);  //resust = 7
    Console.Write(result);
}
else
{
    Console.Write("В данном числе нет третьей цифры");
}