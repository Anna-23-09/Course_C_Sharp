//Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.

int PowNum(int a, int b)
{
    int n_pow = a;

    for (int i = 2; i <= b; i++)
    {
        n_pow *= a;
    }
    return n_pow;
}


Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(PowNum(a, b));
