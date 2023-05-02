// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой. 

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

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(num))
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}