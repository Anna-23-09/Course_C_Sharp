//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Print_1(int[,] array_1) 
{ 
    int row_size = array_1.GetLength(0); 
    int column_size = array_1.GetLength(1); 
    for (int i = 0; i < row_size; i++) 
    { 
        for (int j = 0; j < column_size; j++) 
        { 
            Console.Write($" {array_1[i, j]} "); 
        } 
        Console.WriteLine(); 
    } 
    Console.WriteLine(); 
} 

int [,] MassNums(int row, int column, int from , int  to) 
{ 
    int[,] array_1 = new int [row, column]; 
 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < column; j++) 
        { 
            array_1[i, j] = new Random().Next(from,to); 
        }  
    } 
    return array_1; 
} 

void Print_2(int[,] array_2) 
{ 
    int row_size = array_2.GetLength(0); 
    int column_size = array_2.GetLength(1); 
    for (int i = 0; i < row_size; i++) 
    { 
        for (int j = 0; j < column_size; j++) 
        { 
            Console.Write($" {array_2[i, j]} "); 
        } 
        Console.WriteLine(); 
    } 
    Console.WriteLine(); 
} 

int [,] MassNumbers(int row, int column, int from , int  to) 
{ 
    int[,] array_2 = new int [row, column]; 
 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < column; j++) 
        { 
            array_2[i, j] = new Random().Next(from,to); 
        }  
    } 
    return array_2; 
} 

int[,] MultiMatrix (int[,] arr_1, int[,] arr_2)
{   
    int row_1 = arr_1.GetLength(0);
    int column_1 = arr_1.GetLength(1);
    int row_2 = arr_2.GetLength(0);
    int column_2 = arr_2.GetLength(1);

    int prod = 0;
    int sum = 0;

    if (column_1 != row_2)
        Console.WriteLine("Умножение невозможно");

    int[,] arr_3 = new int [row_1, column_2];
    {
        for (int i = 0; i < arr_1.GetLength(0); i++)
        {
            for (int j = 0; j < arr_2.GetLength(1); j++)
            {
                for (int k = 0; k < arr_1.GetLength(1); k++)
                {
                    arr_3[i, j] = arr_1[i, k] * arr_2[k, j];
                }
            }
        }
        return arr_3;
    }

}

Console.Write("Enter the number of rows_1: ");
int row_1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns_1: ");
int column_1 = int.Parse(Console.ReadLine());


Console.Write("Enter the number of rows_2: ");
int row_2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns_2: ");
int column_2 = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row_1, column_1, 1, 10);
Print_1(arr_1);

int[,] arr_2 = MassNumbers(row_2, column_2, 1, 10);
Print_2(arr_2);

int[,] arr_3 = MultiMatrix(arr_1, arr_2);
Console.WriteLine(arr_3);

