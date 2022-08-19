// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] array) 
{ 
    int row_size = array.GetLength(0); 
    int column_size = array.GetLength(1); 
    for (int i = 0; i < row_size; i++) 
    { 
        for (int j = 0; j < column_size; j++) 
        { 
            Console.Write($" {array[i, j]} "); 
        } 
        Console.WriteLine(); 
    } 
    Console.WriteLine(); 
} 

int [,] MassNums(int row, int column, int from , int  to) 
{ 
    int[,] array = new int [row, column]; 
 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < column; j++) 
        { 
            array[i, j] = new Random().Next(from,to); 
        }  
    } 
    return array; 
} 

int [,] FindMinRow (int [,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    int sum = 0;
    int index = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int max_sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (sum > max_sum)
        {
            sum = max_sum;
            index = i++;
        }
    }
    Console.WriteLine($"{arr} [i] [j]");
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);

FindMinRow(arr_1);
Print(arr_1);