// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



int[] FindElem(int[,] array, int target)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (array[i, j] == target)
            {
                return new int[] { i, j };
            }
        }
    }

    return null;
}

int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

Console.Write("Введите значение элемента: ");
int target = Convert.ToInt32(Console.ReadLine());

int[] position = FindElem(array, target);

if (position != null)
{
    Console.WriteLine($"Позиция элемента {target}: [{position[0]}, {position[1]}]");
}
else
{
    Console.WriteLine($"Элемент {target} не найден.");
}