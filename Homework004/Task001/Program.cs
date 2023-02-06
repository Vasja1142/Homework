//Подсчитать сумму цифр в числе

Console.Clear();

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine()!);
num = Math.Abs(num);
int result = 0;
for(int i = 1; i <= num; i *= 10)
{
    result = result + num % (i * 10) / i;
}
Console.Write($"Сумма цифр в числе = {result}");