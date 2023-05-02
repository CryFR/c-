// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void PrintCubesTable(int n)
{
    Console.WriteLine("Таблица кубов чисел от 1 до " + n + ":");

    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine("{0}^3 = {1}", i, Cube(i));
    }
}

int Cube(int x)
{
    return x * x * x;
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintCubesTable(n);