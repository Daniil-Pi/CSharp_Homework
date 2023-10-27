/*
Задайте двумерный массив, найдите элемент, у которого оба индекса четные и замените эти элементы на их квадрат
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

void Pow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
                array[i,j] *= array[i,j];
        }
    }
}

int[,] array = GetArr(m, n);
Pow(array);
PrintArr(array);