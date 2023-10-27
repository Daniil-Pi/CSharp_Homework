/*
Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь
*/

Console.Clear();

System.Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] GetArr(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

void PrintArr(int[] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

void Find(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            temp++;
    }
    System.Console.WriteLine($"Чисел больше нуля: {temp}");
}

int[] array = GetArr(size);
PrintArr(array);
Find(array);