//Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

void ThirdNum (int a)
{
    if (a < 99)
    {
        Console.WriteLine ("Третьей цифры нет");
        return;
    }

    while (a > 999) a = a/10;
    Console.WriteLine(a % 10);
}
ThirdNum (38);