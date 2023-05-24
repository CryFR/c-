int CountDigits(double number)
{
    string numberString = number.ToString();
    int count = 0;

    foreach (char c in numberString)
    {
        if (Char.IsDigit(c))
        {
            count++;
        }
    }

    return count;
}

Console.Write("Введите число: ");
string input = Console.ReadLine();
double number;

if (Double.TryParse(input, out number))
{
    int digitCount = CountDigits(number);
    Console.WriteLine($"Количество цифр в числе: {digitCount}");
}
else
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
}