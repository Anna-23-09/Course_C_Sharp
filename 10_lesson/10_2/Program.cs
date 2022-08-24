// Выяснить, кратно ли число заданному, если нет, вывести остаток.

void Multiplicity (int a, int b)
{
    if (a % b == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
        Console.WriteLine($"Некратно, остаток : {a % b}");
}

Console.WriteLine ("Введите 1 число: ");
int a = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите 2 число: ");
int b = int.Parse (Console.ReadLine());
Multiplicity (a, b);

