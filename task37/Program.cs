/*
Найдите произведение пар чисел в одномерном массиве
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
        array[i] = new Random().Next(1, 10);
        System.Console.Write(array[i] + " ");
    }

    return array;
}

void Find(int[] array)
{
    int count = 0;
    for(int i = 0; i <= (array.Length/2); i++)
    {
        if (i == array.Length/2)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("Ответ: " + array[array.Length/2]);
            break;
        }
        count = array[i] * array[array.Length - 1 - i];
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.WriteLine("Ответ: " + count);
    }
    
    
}

int[] array = Massive(size);

System.Console.WriteLine();
Find(array);
