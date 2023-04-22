
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;

Console.Write("Квадрат числа: ");
Console.WriteLine(result);

if (num > 0)
{
    Console.WriteLine("Было введено положительное число.");
}
else if (num == 0)
{
    Console.WriteLine("Был введен нуль.");

}
else
{
    Console.WriteLine("Было введено отрицательное число.");
}