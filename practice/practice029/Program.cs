
int[] ReadArray(int size)
{
    int[] array = new int[size];

    Console.WriteLine($"Введите {size} элементов массива через запятую:");
    string input = Console.ReadLine();

    string[] values = input.Split(',');

    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(values[i].Trim());
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}
int[] array = ReadArray(8);

Console.WriteLine("Введенные элементы массива:");
PrintArray(array);
