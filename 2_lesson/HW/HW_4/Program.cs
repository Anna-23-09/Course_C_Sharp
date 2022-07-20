//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOfWeek (int a)

{
    if (a == 6 || a == 7)
    Console.WriteLine ("Yes");
    else 
    Console.WriteLine("No");
}
DayOfWeek (7);