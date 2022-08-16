//Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for(int i = 0; i < row_size; i++)
    {
        for(int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }        
    }
    return arr;    
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int Average (int [,] arr, int sum_num)
{   
    for (int i = 0; i < arr.GetLength(0); i++)
    {   
        int ave_arr = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            ave_arr = arr [i, j];
            j++;
            sum_num = arr [i, j];
        }
    }
}

int[,] arr_1 = MassNums(row, column, 1, 11);

Print (arr_1);
Average ();


