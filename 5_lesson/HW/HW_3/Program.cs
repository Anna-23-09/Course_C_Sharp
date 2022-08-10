//Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
double[] MassNums(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-10, 10);
    }
    return arr;
}

void Diff (double[] arr)
{
    int size = arr.Length;
    double max_num = 0;
    double min_num = 0;

    for ( int i = 0; i < size; i ++)
    {
        if (arr[i] > max_num)
        max_num = arr[i];   
        if (arr[i] < min_num)
        min_num = arr[i];
    }
    Console.WriteLine(max_num - min_num);

}
double[] arr = MassNums(7);
Print(arr);
Diff(arr);

