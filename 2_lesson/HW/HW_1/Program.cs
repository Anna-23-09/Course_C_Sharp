﻿// Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void NumSec (int num)
{
    Console.WriteLine (num / 10 % 10);
}

NumSec (593);
