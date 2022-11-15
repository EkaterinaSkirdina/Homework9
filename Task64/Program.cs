/* Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа
 в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2," */

void Main()
{
    Console.WriteLine("Введите число");
    int number = int.Parse(Console.ReadLine());
    OutputOfEvenNumbers(number);
}

void OutputOfEvenNumbers(int arg)
{
    if (arg < 1) return;

    if (arg % 2 == 0)
    {
        Console.Write($"{arg},  ");
        OutputOfEvenNumbers(arg - 1);
    }
    else OutputOfEvenNumbers(arg - 1);
}

Main();
