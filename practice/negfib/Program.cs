// Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.

// Пример:

// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]


int[] NegaFib(int k)
{
    int[] negaFibonacci = new int[2 * k + 1];
    negaFibonacci[k] = 0;

    int a = 21;
    int b = 13;

    for (int i = k - 1; i >= -k; i--)
    {
        if (i == 0)
        {
            negaFibonacci[k] = 1;
        }
        else if (i == 1)
        {
            negaFibonacci[k + 1] = 1;
        }
        else if (i == -1)
        {
            negaFibonacci[k - 1] = -1;
        }
        else
        {
            int c = a - b;
            negaFibonacci[k + i] = c;
            a = b;
            b = c;
        }
    }

    return negaFibonacci;
}

int k = 9;
int[] negaFibonacci = NegaFib(k);

Console.WriteLine("Массив НегаФибоначчи:");
foreach (int num in negaFibonacci)
{
    Console.Write(num + " ");
}
