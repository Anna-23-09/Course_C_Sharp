// Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.

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

void OrderingDescending (int [,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {         
           for (int k = 0; k < arr.GetLength(1) - 1; k++)
           {
            if (arr[i, k] < arr[i, k + 1])
                {
                    (arr [i, k], arr [i, k + 1]) = (arr [i, k + 1], arr [i, k]);
                }
            }
        }
            // arr[i, j] = new Random().Next(range);
            // Console.Write(array[i, j] + " ");

            // arr[i, j] = arr[max];
            // Console.WriteLine(arr[i, j] + "");
            // j++;
    }
        
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 1, 10);
Print(arr_1);

OrderingDescending(arr_1);
Print(arr_1);

 