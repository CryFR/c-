// Имеется массив случайных целых чисел. Создайте массив, в который попадают числа, описывающие максимальную сплошную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.

// Пример:

// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7

// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность длиннее чем от 7 до 8

// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность длиннее чем от 7 до 8.


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 15);
}

void PrintArray(int[] array)
{
    foreach (int i in array)
        Console.Write($"{i} ");
    System.Console.WriteLine();
}

int[] FindMaxSeq(int[] array)
    {
        int maxLength = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int currentNumber = array[i];
            int currentLength = 1;

            while (Array.IndexOf(array, currentNumber + 1) != -1)
            {
                currentNumber++;
                currentLength++;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                startIndex = array[i];
                endIndex = currentNumber;
            }
        }

        int[] longestSequence = { startIndex, endIndex };
        return longestSequence;
    }

int[] array = new int[8];
FillArray(array);
PrintArray(array);
int[] maxSequence = FindMaxSeq(array);
Console.WriteLine("Наибольшая последовательность чисел");
Console.WriteLine($"Начало: {maxSequence[0]}, Конец: {maxSequence[1]}");