﻿//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round (Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2)), 3);
}

Console.WriteLine (Distance (3, 4, 8, 1, 9, 2));

