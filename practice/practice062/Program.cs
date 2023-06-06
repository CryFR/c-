// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiral(int[,] array)
{
    int value = 1;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int rowStart = 0;
    int rowEnd = rows - 1;
    int columnStart = 0;
    int columnEnd = columns - 1;

    while (value <= rows * columns)
    {
        // Заполнение верхней строки слева направо
        for (int i = columnStart; i <= columnEnd; i++)
        {
            array[rowStart, i] = value++;
        }
        rowStart++;

        // Заполнение правого столбца сверху вниз
        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, columnEnd] = value++;
        }
        columnEnd--;

        // Заполнение нижней строки справа налево
        for (int i = columnEnd; i >= columnStart; i--)
        {
            array[rowEnd, i] = value++;
        }
        rowEnd--;

        // Заполнение левого столбца снизу вверх
        for (int i = rowEnd; i >= rowStart; i--)
        {
            array[i, columnStart] = value++;
        }
        columnStart++;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
FillSpiral(array);
PrintArray(array);


