﻿/*
Задайте двумерный массив, найдите сумму элементов, находящихся на главной диагонали
*/

Console.Clear();

System.Console.Write("Введите высоту: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите ширину: ");
int n = int.Parse(Console.ReadLine());

int[,] GetArr(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,11);
        }
    }
    return array;
}

void PrintArr(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Diag(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
       sum += array[i,i];
    }
    System.Console.WriteLine($"Сумма элементов равна: {sum}");
}

int[,] array = GetArr(m, n);
PrintArr(array);
Diag(array);