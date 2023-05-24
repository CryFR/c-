// Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}

int FindMaxElement(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int FindMinElement(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double CalculateAverage(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return (double)sum / array.Length;
}

double CalculateMedian(int[] array)
{
    Array.Sort(array);

    if (array.Length % 2 == 0)
    {
        int middleIndex1 = array.Length / 2 - 1;
        int middleIndex2 = array.Length / 2;
        return (array[middleIndex1] + array[middleIndex2]) / 2.0;
    }
    else
    {
        int middleIndex = array.Length / 2;
        return array[middleIndex];
    }
}

int[] array = new int[4];
FillArray(array);

// Находим максимальный элемент и его индекс
int maxElement = FindMaxElement(array);
int maxIndex = Array.IndexOf(array, maxElement);

// Находим  минимальный элемент и его индекс
int minElement = FindMinElement(array);
int minIndex = Array.IndexOf(array, minElement);

// Вычисляем среднее арифметическое всех элементов
double average = CalculateAverage(array);

// Создаем массив для сохранения информации???
object[] infoArray = new object[5];
infoArray[0] = numbers;
infoArray[1] = maxElement;
infoArray[2] = maxIndex;
infoArray[3] = minElement;
infoArray[4] = minIndex;

Console.WriteLine("Исходный массив: [{0}]", string.Join(", ", array));
Console.WriteLine("Максимальный элемент: {0}, индекс: {1}", maxElement, maxIndex);
Console.WriteLine("Минимальный элемент: {0}, индекс: {1}", minElement, minIndex);
Console.WriteLine("Среднее арифметическое: {0}", average);

// Находим медианное значение
double median = CalculateMedian(array);
Console.WriteLine("Медианное значение: {0}", median);