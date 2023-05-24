//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}
void PrintArray(int[] array)
{
    foreach (int i in array)
        Console.Write($"{i} ");
    System.Console.WriteLine();
}

int SumOfOdd(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int [] array =  new int[4];
FillArray(array);
PrintArray(array);
int sum = SumOfOdd(array);
Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);