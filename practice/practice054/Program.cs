// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void SortRows(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        int[] tempRow = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            tempRow[j] = array[i, j];
        }
        Array.Sort(tempRow);
        Array.Reverse(tempRow);
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = tempRow[j];
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };
Console.WriteLine("Исходный массив:");
PrintArray(array);

SortRows(array);
Console.WriteLine("Упорядоченный массив:");
PrintArray(array);
