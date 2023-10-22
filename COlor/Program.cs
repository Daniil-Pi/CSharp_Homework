/**/


int[] GetArray(int start, int end, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}


void PrintArray(int[] arr)
{
    for(int i=0; i < arr.Length; i++)
    {
        int j = new Random().Next(0, 4);
        if (j == 0)
        Console.ForegroundColor = ConsoleColor.Magenta;
        else if (j == 1)
        Console.ForegroundColor = ConsoleColor.Blue;
        else if (j == 2)
        Console.ForegroundColor = ConsoleColor.Cyan;
        else
        Console.ForegroundColor = ConsoleColor.Green;
        Thread.Sleep(250);
        System.Console.Write(arr[i] + " ");
        Console.ResetColor();
    }
    Console.ResetColor();
}

int[] array = GetArray(0, 5, 10);
PrintArray(array);
System.Console.WriteLine();
