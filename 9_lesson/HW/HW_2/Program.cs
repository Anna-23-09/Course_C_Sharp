// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumOfNumbers (int a, int b)
{
    if (a > b) return a;
    return SumOfNumbers (a, b - 1) + a;
    Console.WriteLine($"{a}, ");
}
SumOfNumbers(2, 5);