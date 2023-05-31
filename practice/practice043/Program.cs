// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] GetLine()
{
    Console.Write("Введите значение b для уравнения y = kx + b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите значение k для уравнения y = kx + b: ");
    double k = Convert.ToDouble(Console.ReadLine());

    return new double[] { k, b };
}

double Intersection(double[] line1, double[] line2)
{
    double k1 = line1[0];
    double b1 = line1[1];
    double k2 = line2[0];
    double b2 = line2[1];

    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны, нет точки пересечения.");
    }

    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double CalculateY(double[] line, double x)
{
    double k = line[0];
    double b = line[1];

    double y = k * x + b;
    return y;
}

double[] line1 = GetLine();
double[] line2 = GetLine();

double x = Intersection(line1, line2);
double y = CalculateY(line1, x);

Console.WriteLine($"Точка пересечения: ({x}, {y})");
