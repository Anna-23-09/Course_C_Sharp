//Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}
int SumNumEven (int[] arr)
{
    int size = arr.Length;
    int num_sum = 0;        

    for (int i = 0; i < size; i += 2)
    {
        num_sum += arr[i];
    }
    return num_sum;
}

int[] arr = MassNums(5, 1, 11);
Print(arr);
Console.WriteLine(SumNumEven(arr));

