// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

int[,] RandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(100);
        }
    }

    return array;
}

void SortArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[] flatArray = new int[rows * columns];
    int index = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            flatArray[index] = array[i, j];
            index++;
        }
    }

    Array.Sort(flatArray);
    index = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = flatArray[index];
            index++;
        }
    }
}
void OutputArray(int[,] array, int m, int n)
{
    Console.WriteLine("Отсортированный массив:");

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = RandomArray(rows, columns);

SortArray(array);
OutputArray(array, rows, columns);