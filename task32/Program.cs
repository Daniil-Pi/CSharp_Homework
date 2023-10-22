/*
Напишите программу замены элементов массива 
положительные элементы заменить на соответствующие отрицательные и наоборот
*/

Console.Clear();

System.Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
System.Console.Write("Введите минимум: ");
int min = int.Parse(Console.ReadLine());
System.Console.Write("Введите максимум: ");
int max = int.Parse(Console.ReadLine());

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

void Swap(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        array[i] *= (-1);
        System.Console.Write(array[i] + " ");
    }
}

int[] array = Massive(size, min, max);

System.Console.WriteLine();

Swap(array);