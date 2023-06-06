// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] FillArray(int[,,] array, int number)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                array[i, j, k] = number++;
            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    int dim1 = array.GetLength(0);
    int dim2 = array.GetLength(1);
    int dim3 = array.GetLength(2);

    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                Console.Write(array[i, j, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
void PrintWithIndex(int[,,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine($"array[{i}][{j}][{k}] = {array[i, j, k]}");
            }
        }
    }
}

int[,,] array = new int[2, 2, 2];
int number = 10;
FillArray(array, number);
PrintArray(array);
PrintWithIndex(array);