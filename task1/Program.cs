/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int nums = InputNumbers("Введите число: ");
PrintNumbers(nums);

int InputNumbers(string input)
{
    Console.Write(input);
    return int.Parse(Console.ReadLine()!);
}

void PrintNumbers(int n)
{
    if (n == 1)
    {
        Console.WriteLine(1);
        return;
    }
    Console.Write($"{n} ");
    PrintNumbers(n - 1);
}