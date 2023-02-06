//Написать программу вычисления произведения чисел от 1 до N

Console.Clear();

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine()!);
int result = 1;

for(int i = 1; i <= num; i++)
{
    result = result * i;
}
Console.Write($"Произведение всех чисел от 1 до {num} = {result}");