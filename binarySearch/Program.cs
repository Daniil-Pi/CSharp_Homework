/*
Количество попыток с помощью бинарного поиска можно найти по формуле - log2N, где N - количество элементов
*/
Console.Clear();

System.Console.Write("Введите размер: ");
int S = int.Parse(Console.ReadLine());

int[] CreateArr(int s)
{
    int[] arr = new int[s];
    for (int i = 0; i < s; i++)
    {
        System.Console.Write("Введи число: ");
        arr[i] = int.Parse(Console.ReadLine());
    }

    System.Console.WriteLine();

    for (int k = 0; k < s; k++)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        System.Console.Write(k + "\t");
        Console.ResetColor();
    }

    System.Console.WriteLine();

    for (int j = 0; j < s; j++)
    {
        
        System.Console.Write(arr[j] + "\t");
    }

    System.Console.WriteLine();
    return arr;
}

int BinarySearch(int[] arr, int numb)
{
    int low = 0;
    int high = arr.Length - 1;
    int mid;
    int guess;
    while (low <= high)
    {
        mid = (low + high)/2;
        guess = arr[mid];
        if (guess == numb)
            return mid;
        if (guess > numb)
            high = mid - 1;
        if (guess < numb)
            low = mid + 1;
    }
    return 0;
}

int[] arr = CreateArr(S);
System.Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());

int item = BinarySearch(arr, numb);
System.Console.WriteLine(item);