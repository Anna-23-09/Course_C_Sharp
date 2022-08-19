// Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

int NaturalNumbers (int a, int b)
{
    if (a % 2 == 0) return a;
    return NaturalNumbers(a, b - 1);
    Console.WriteLine($"{a + 2}, ");
}
Console.WriteLine(NaturalNumbers(15, 29));