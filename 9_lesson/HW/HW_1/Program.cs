// Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

void NaturalNumbers (int a, int b)
{
    if (a > b) return;
    NaturalNumbers(a, b - 1);
    if (b % 2 == 0)
    Console.Write($"{b}, ");
}
NaturalNumbers(1, 10);

