/*
Задайте одномерный массив из 123 случайных чисел,
найдите количество элементов массива значение которых лежат в отрезке 10 - 99
*/

Console.Clear();

System.Console.Write("Введите размер массива: ");
Console.ForegroundColor = ConsoleColor.Cyan;
int size = int.Parse(Console.ReadLine());
Console.ResetColor();


int[] Massive(int size)
{
    int[] array = new int[size];
    for (int i=0; i < size; i++)
    {  
        array[i] = new Random().Next(10, 1000);
        Console.ForegroundColor = ConsoleColor.Magenta;
        if (array[i] > 9 && array[i] < 100)
        Console.ForegroundColor = ConsoleColor.DarkRed;
        System.Console.Write(array[i] + " ");
    }
    Console.ResetColor();
    return array;
}

void Find(int[] array)
{
    int count = 0;
    foreach(int i in array)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        if (i > 9 && i < 100)
        count++;
    }
    System.Console.WriteLine("Количество двухзначных: " + count);
}

int[] array = Massive(size);

System.Console.WriteLine();
Find(array);
