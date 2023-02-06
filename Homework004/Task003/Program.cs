//Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Все четные кубы чисел от 0 до {num}");
int count = 0;
Console.WriteLine("0^3 = 0");
while (num > count)
{
    count++;
    double result = Math.Pow(count, 3);
    if (result % 2 == 0)
    {
        Console.WriteLine($"{count}^3 = {result}");
    }
}

while (num < count)
{
    count--;
    double result = Math.Pow(count, 3);
    if (result % 2 == 0)
    {
        Console.WriteLine($"{count}^3 = {result}");
    }
}
