// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4


int PosNum(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }

    return count;
}

void FillArr(int[] array)
{
    Console.WriteLine("Введите числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}


Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArr(array);
int count = PosNum(array);
Console.WriteLine($"Количество чисел больше 0: {count}");

