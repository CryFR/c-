//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble() * 5;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double FindDiff(double[] array)
{
        double max = array[0];
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        double difference = max - min;
        return difference;
}

double[] array = new double[4];
FillArray(array);
PrintArray(array);
double diff = FindDiff(array);
Console.WriteLine("Разница: " + diff);