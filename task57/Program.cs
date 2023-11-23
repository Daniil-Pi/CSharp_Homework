/*
Составить частотный словарь элементов двумерного массива
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных
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

void Slovar(int[,] arr)
{
    List<int> list = new List<int>();

    foreach (int item in arr)
    {
        if (!list.Contains(item))
        {
            int count = 0;
            foreach (int checkitem in arr)
            {
                if (item == checkitem)
                count++;
            }
            System.Console.WriteLine(item + " встречается " + count + " раз ");
         
        }
        list.Add(item);
    }
}

int[,] array = CreateArr(length, width);
PrintArr(array);
System.Console.WriteLine();
Slovar(array);