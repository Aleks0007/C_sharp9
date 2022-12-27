/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();
int m = InputNumbers("Введите первое число: ");
int n = InputNumbers("Введите второе число: ");

int sum = SumNumbers(m, n);
if (m < 0 || n < 0) Console.WriteLine("Число не является натуральным");
else Console.WriteLine($"Сумма натуральных элементов = {sum}");

int InputNumbers(string input)
{
    Console.Write(input);
    return int.Parse(Console.ReadLine()!);
}

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }

    return m + SumNumbers(m + 1, n);
}