/*
Задан одномерный массив целых чисел. Образуйте из него два отсортированных по возрастанию массива, 
содержащих четные и нечетные числа. Подсказка: четное число делится на 2 без остатка
*/

Console.Clear();

System.Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] PrintArr(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0,21);
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
    return arr;
    
}

int[] list = PrintArr(size);

int[] CountNeChet(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        count += 1;
    }

    int[] ArrNeChet = new int[count];
    int n = 0;

    for (int i = 0; i < ArrNeChet.Length; i++)
    {
        for (int j = n; j < arr.Length; j++)
        {
            if (arr[j] % 2 != 0)
            {
                ArrNeChet[i] = arr[j];
                n = j;
                break;
            }
        }
        if (n != arr.Length)
        n++;
        else
        break;
    }

    return ArrNeChet;
}

int[] CountChet(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        count += 1;
    }

    int[] ArrChet = new int[count];
   int n = 0;

    for (int i = 0; i < ArrChet.Length; i++)
    {
        for (int j = n; j < arr.Length; j++)
        {
            if (arr[j] % 2 == 0)
            {
                ArrChet[i] = arr[j];
                n = j;
                break;
            }
        }
        if (n != arr.Length)
        n++;
        else
        break;
    }
    
    return ArrChet;
}

void ListChet(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                min = arr[i];
                arr[i] = arr[j];
                arr[j] = min;
            }
        }
    }
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}



int[] NeChet = CountNeChet(list);
int[] Chet = CountChet(list);
System.Console.WriteLine("Четные: ");
ListChet(Chet);
System.Console.WriteLine();
System.Console.WriteLine("Нечетные: ");
ListChet(NeChet);

