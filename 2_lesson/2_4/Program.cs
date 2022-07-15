//  Напишите программу, которая принимает на вход
//число и проверяет, кратно ли оно одновременно 7 и
//23.
void Checking (int N)
{
    if(N % 7 == 0 && N % 23 == 0)
    Console.WriteLine ("Кратно");
    else
    Console.WriteLine ("Некратно");
}
Console.Write("Введите число : ");
int = int.Parse(Console.ReadLine());

Checking(n);

