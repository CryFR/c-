// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = 0;
while (number > 99)
{
    if (number < 999)
    {
        thirdDigit = number % 10;
        break;
    }
    number /= 10;
}

if (number < 100)
{
Console.WriteLine("Третьей цифры нет");
}
else
{
Console.WriteLine($"Третья цифра числа: {thirdDigit}");
}

