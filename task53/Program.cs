/*
Задать двумерный массив, поменять местами первую и последнюю строку массива
*/

Console.Clear();

System.Console.Write("Задайте длину массива: ");
int length = int.Parse(Console.ReadLine());
System.Console.Write("Задайте ширину массива: ");
int width = int.Parse(Console.ReadLine());

int[,] CreateArr(int a, int b)
{
    int[,] arr = new int[a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            arr[i,j] = new Random().Next(1,11);
        }
    }
    return arr;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] Replace(int[,] arr)
{
    int[] temp = new int[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        temp[j] = arr[0,j];
        arr[0,j] = arr[arr.GetLength(0)-1, j];
        arr[arr.GetLength(0)-1, j] = temp[j];
    }
    return arr;
}

int[,] array = CreateArr(length, width);
PrintArr(array);
System.Console.WriteLine();
PrintArr(Replace(array));