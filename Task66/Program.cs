/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

void Main()
{
    Console.WriteLine("Задайте значение M: ");
    int M = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте значение N: ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine(SumNum(M, N));
}

int SumNum(int num1, int num2)
{
    if (num1 == num2) return num1;
    int sum = 0;
    return sum = num1 + SumNum(num1 + 1, num2);
}

Main();
