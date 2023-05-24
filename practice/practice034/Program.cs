//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}
void PrintArray(int[] array)
{
    foreach (int i in array)
        Console.Write($"{i} ");
    System.Console.WriteLine();
}
int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int [] array =  new int[4];
FillArray(array);
PrintArray(array);
int count = CountEvenNumbers(array);
Console.WriteLine("Количество четных чисел: " + count);