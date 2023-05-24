static int GetDigitSum(int number)
{
    int sum = 0;

    while (number != 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }

    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = GetDigitSum(number);

Console.WriteLine("Сумма цифр: " + sum);