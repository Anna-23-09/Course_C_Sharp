//Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку
//массива.

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

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            arr[i, j] = i + j;
        }        
    }
    return arr;    
}

int[,] FillArrayReverseFirstEndRow (int[,] arr)
{
    int temp = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        temp = arr [0, j];
        arr [0, j] = arr [arr.Length(0) - 1, j];
        arr [arr.Length(0) - 1, j] = temp;        
    } 
    Console.WriteLine();
    return arr;
}
//
//void FirstWithLast (int[,] arr)
//{
    //for (int i = 0; i <column; i++)
    //{
        //arr [0, 1], arr [row - 1, i] = arr [row - 1, i], arr [0, 1],
    //}
//}
Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);

FirstWithLast(arr_1);
Print(arr_1);

