// на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

Console.Write("Введите число: ");
string input = Console.ReadLine();

if (input.Length >= 2)
{
    string output = input.Remove(1, 1);
    Console.WriteLine(output);
}
else
{
    Console.WriteLine("нет");
}
