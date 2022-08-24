// Даны два числа. Показать большее и меньшее число
// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

void Numbers (int a)
{
    if (a < 10 || a > 99)
    Console.WriteLine("Решение невозможно");
    else 
    {
        if (a % 10 > a / 10)
        Console.WriteLine($"{a % 10}");
        else Console.WriteLine($"{a / 10}");
            
    }
}
Console.WriteLine ("Введите 2-значное число");
int a = int.Parse (Console.ReadLine());
Numbers(a);

