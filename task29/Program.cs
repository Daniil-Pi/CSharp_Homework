/*
Напишите программу, которая задает массивиз 8 элементов и выводит их на экран
*/

Console.Clear();

System.Console.Write("Введите минимум: ");
int min = int.Parse(Console.ReadLine());
System.Console.Write("Введите максимум: ");
int max = int.Parse(Console.ReadLine());

void Array(int size, int a, int b)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] =  new Random().Next(a, b+1);
        System.Console.Write(array[i] + " ");
    }
}

Array(8, min, max);