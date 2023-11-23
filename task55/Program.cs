/*
Задайте двумерный массив, замените строки на столбцы
в случае если это невозможно, программа должна выдать ошибку
*/
Console.Clear();
System.Console.Write("Задайте длину массива: ");
int length = int.Parse(Console.ReadLine());
System.Console.Write("Задайте ширину массива: ");
int width = int.Parse(Console.ReadLine());

if(length != width)
    System.Console.WriteLine("Ошибка!!!");
else
{
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
    int[,] newArr = new int[arr.GetLength(0),arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArr[j,i] = arr[i,j];
        }
    }
    return newArr;
}

int[,] array = CreateArr(length,width);
PrintArr(array);
System.Console.WriteLine();
PrintArr(Replace(array));

}