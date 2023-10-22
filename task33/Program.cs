/*
Напишите программу, которая определяет присутсвует ли заданное число в массиве
*/

Console.Clear();
System.Console.Write("Введите число: ");
Console.ForegroundColor = ConsoleColor.Cyan;
int numb = int.Parse(Console.ReadLine());
Console.ResetColor();
System.Console.Write("Введите размер массива: ");
Console.ForegroundColor = ConsoleColor.Cyan;
int size = int.Parse(Console.ReadLine());
Console.ResetColor();
System.Console.Write("Введите минимум: ");
Console.ForegroundColor = ConsoleColor.Cyan;
int min = int.Parse(Console.ReadLine());
Console.ResetColor();
System.Console.Write("Введите максимум: ");
Console.ForegroundColor = ConsoleColor.Cyan;
int max = int.Parse(Console.ReadLine());
Console.ResetColor();

int[] Massive(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i=0; i < size; i++)
    {  
        array[i] = new Random().Next(min, max+1);
        Console.ForegroundColor = ConsoleColor.Magenta;
        System.Console.Write(array[i] + " ");
    }
    Console.ResetColor();
    return array;
}



void Find(int[] array, int numb)
{
    bool flag = false;
    foreach(int i in array)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        if (i == numb)
        flag = true;
    }
    if (flag == true)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("Ваше число присутствует в массиве!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        System.Console.WriteLine("Ваше число не присутствует в массиве!");
    }
}

int[] array = Massive(size, min, max);

System.Console.WriteLine();

Find(array, numb);
