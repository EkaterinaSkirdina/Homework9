/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

void Main()
{
    Console.WriteLine("Задайте значение m: ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте значение n: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine(AckermanFunctionCalculate(m, n));
}

int AckermanFunctionCalculate(int arg1, int arg2)
{
    if (arg1 == 0)
    {
        return arg2 + 1;
    }
    else if (arg1 > 0 && arg2 == 0)
    {
        return AckermanFunctionCalculate(arg1 - 1, 1);
    }
    else
    {
        return AckermanFunctionCalculate(arg1 - 1, AckermanFunctionCalculate(arg1, arg2 - 1));
    }
}

Main();