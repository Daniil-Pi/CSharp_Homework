/*
Напишите программу, которая перевернет одномерный массив
*/

Console.Clear();

System.Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] Array(int s)
{
    int[] arr = new int[s];
    for (int i=0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 11);
        System.Console.Write($"{arr[i]} ");
    }
    return arr;
}

void TurnOver(int[] array)
{
    for (int i = array.Length-1; i >= 0; i--)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int[] array = Array(size);
System.Console.WriteLine();
TurnOver(array);
