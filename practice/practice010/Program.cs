// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = 0;
while (number > 0)
{
    if (number < 100)
    {
        secondDigit = number % 10;
        break;
    }
    number /= 10;
}

Console.WriteLine($"Вторая цифра: {secondDigit}");