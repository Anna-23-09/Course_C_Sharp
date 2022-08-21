// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumOfNumbers (int a, int b)
{
    if (a >= b) return b;
    return SumOfNumbers (a, b - 1) + b;
    Console.WriteLine($"{b}, ");
}
Console.WriteLine(SumOfNumbers(2, 10));