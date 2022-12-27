/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();
int num1 = InputNumbers("Введите первое число: ");
int num2 = InputNumbers("Введите второе число: ");

int result = Ackermann(num1, num2);

if (num1 < 0 || num2 < 0) Console.WriteLine("Введённое число не является неотрицательным");
else Console.WriteLine(result);

int InputNumbers(string input)
{
    Console.Write(input);
    return int.Parse(Console.ReadLine()!);
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return 0;
}