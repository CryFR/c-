// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int MinimumSum(int[,] array)
{
    int minSum = int.MaxValue;
    int rowIndex = -1;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            rowIndex = i + 1;
        }
    }

    return rowIndex;
}

int[,] array ={
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

int rowWithMinSum = MinimumSum(array);

Console.WriteLine("Строка с наименьшей суммой элементов: " + rowWithMinSum);
