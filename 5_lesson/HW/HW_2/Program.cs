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
int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void SumNumEven (int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i += 2)
    {
        num_sum = 0;
        if (arr[i] < size)
            num_sum += arr[i];
    }
}

int[] arr = MassNums(10);
Print(arr);
SumNumEven(arr);
Console.WriteLine(num_sum);

