//Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.

void Searching (int a)
{
    int b = 1;
    while (b <= a)
    {
        Console.WriteLine(Math.Pow(b, 2));
        b = b+1;
    }
}
Searching(6);
