/*
Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле A[m,n] = m + n, 
выведите полученный массив на экран
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
            array[i,j] = i + j;
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

int[,] array = GetArr(m, n);
PrintArr(array);