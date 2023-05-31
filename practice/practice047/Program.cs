// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int m = 3;
int n = 4;

void PrintArr(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
double[,] RandomArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double randomDouble = random.NextDouble() * 20;
            double roundedValue = Math.Round(randomDouble * 100) / 100;
            array[i, j] = roundedValue;
        }
    }

    return array;
}

double[,] array = RandomArray(m, n);
PrintArr(array);

