bool IsPalindrome(int number)
{
    int temp = number;
    int reverse = 0;
    while (temp != 0)
    {
        int remainder = temp % 10;
        reverse = reverse * 10 + remainder;
        temp /= 10;
    }
    return number == reverse;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999)
{
    if (IsPalindrome(number))
    {
        Console.WriteLine("Число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом.");
    }
}
else
{
    Console.WriteLine("Введено некорректное число.");
}
