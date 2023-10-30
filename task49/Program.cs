/*
Поиск элемента по позиции
*/

Console.Clear();

System.Console.Write("Введите высоту массива: ");
int n = int.Parse(Console.ReadLine());
System.Console.Write("Введите ширину массива: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите число, на которое увеличивается каждый новый элемент массива: ");
int k = int.Parse(Console.ReadLine());
System.Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());
System.Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            System.Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}
  
int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n,m];
    int temp = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i,j] = temp;
            temp += k;
        }
    }
    return matrix;
}

void Find(int[,] array, int x, int y)
{
    if (x>array.GetLength(0)-1 || x<0 || y>array.GetLength(1)-1 || x<0)
    {
        System.Console.WriteLine($"Индексы x = {x} и y = {y} выходят за пределы массива!");
    }
    else
    {
        System.Console.WriteLine($"Элемент с индексами x = {x} и y = {y} равен: {array[x,y]}");
    }
}

int[,] array = CreateIncreasingMatrix(n,m,k);
PrintArray(array);
Find(array,x,y);