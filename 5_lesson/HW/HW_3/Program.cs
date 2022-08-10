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
    double[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-10, 10, 2);
    }
    return arr;
}

void Diff (double[] arr)
{
    int size = arr.Length;
    int max_num = 0;
    int min_num = 0;
    double num_diff = max_num - min_num;
    for ( int i = 0; i < size; i ++)
    {
        if (arr[i] > max_num)
        max_num = arr[i];   
        if (arr[i] < min_num)
        min_num = arr[i];
    }
    Console.WriteLine(num_diff);

}
double[] arr = MassNums(7);
Print(arr);
Diff(arr);

