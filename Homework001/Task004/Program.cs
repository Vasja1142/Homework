//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int a = 2;

while (num >= a)
{
    Console.WriteLine(a);
    a+=2;
}

