/*
Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования
*/

Console.Clear();

System.Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] array_1(int s)
{
    int[] array = new int[s];
    System.Console.Write("Первый массив: ");
    for (int i = 0; i < s; i++)
    {
        array[i] = new Random().Next(1, 11);
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.Write(array[i] + " ");
    }
    Console.ResetColor();
    return array;
}

int[] array_2(int[] arr)
{
    int[] array = new int[arr.Length];
    System.Console.Write("Второй массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = arr[i];
        Console.ForegroundColor = ConsoleColor.Magenta;
        System.Console.Write(arr[i] + " ");
    }
    Console.ResetColor();
    return array;
}

int[] ListOne = array_1(size);
System.Console.WriteLine();
array_2(ListOne);