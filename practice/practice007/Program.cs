// Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

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

if (number < 10)
{
    Console.WriteLine("Второй цифры слева нет.");
}
else
{
    Console.WriteLine("Вторая цифра слева: " + secondDigit);
}
