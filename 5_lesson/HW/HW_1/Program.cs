﻿//Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void Multiple(int[] arr)
{
    int size = arr.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
       if(arr[i] % 2 == 0);
            count = count + 1;
    }
    Console.WriteLine(count);
}

int[] arr = MassNums(10);
Print(arr);
Multiple(arr);


