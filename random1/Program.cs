Console.Clear();
System.Console.Write("Введите длину куба: ");
int len = int.Parse(Console.ReadLine());

int[,] Result(int len)
{
    int[,] arr = new int[len,len];
    for (int i = 0; i < len; i++)
    {
        for (int j = i; j < len; j++)
        {
            arr[i,j] = (i+1) * (j+1);
            arr[j,i] = (i+1) * (j+1);
        }
    }
    return arr;

}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            System.Console.Write(arr[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}
int[,] array = Result(len);
PrintArr(array);