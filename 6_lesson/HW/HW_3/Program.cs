//Напишите программу, которая будет создавать копию заданного массива(вещественные числа) 
//с помощью поэлементного копирования.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double [] MassNums(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-10, 10);
    }
    return arr;
}

double Copy (double [] arr)
{
    int size = arr.Length;
    int new_size = size;
    double[] new_arr = new double [new_size];

    for (int i = 0; i <= size; i++)
        new_arr[i] = arr[i];
    return new_arr;
}

double [] arr = MassNums(7);
Print(arr);
double [] new_arr = Copy (arr);
Print(new_arr);

