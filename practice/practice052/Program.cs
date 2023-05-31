// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[] CalculateColumnAverages(int[,] array)
{
    int rowCount = array.GetLength(0);
    int columnCount = array.GetLength(1);

    double[] columnSums = new double[columnCount];

    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            columnSums[j] += array[i, j];
        }
    }

    double[] columnAverages = new double[columnCount];

    for (int j = 0; j < columnCount; j++)
    {
        double avg = columnSums[j] / rowCount;
        columnAverages[j] = Math.Round(avg * 100) / 100;
    }

    return columnAverages;
}

int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

double[] columnAverages = CalculateColumnAverages(array);

for (int i = 0; i < columnAverages.Length; i++)
{
    Console.WriteLine($"Среднее арифметическое элементов в столбце {i + 1}: {columnAverages[i]}");
}
