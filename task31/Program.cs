/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка от -9 до 9,
найдите сумму отрицательных и положительных элементов массива
*/

Console.Clear();

int[] EnterArray()
{
    int[] array = new int[12];
    for (int i = 0; i < 12; i++)
    {
        array[i] = new Random().Next(-9,10);
        System.Console.Write(array[i] + "  ");
    }
    return array;
}

int[] array = EnterArray();


void SumOtr(int[] array)
{
    int sum = 0;
    foreach(int value in array)
    {
        if (value < 0) 
        sum += value;
    }
    System.Console.WriteLine($"Сумма отрицательных чисел: {sum}");
}

void SumPol(int[] array)
{
    int sum = 0;
    foreach(int value in array)
    {
        if (value >= 0) 
        sum += value;
    }
    System.Console.WriteLine($"Сумма положительных чисел {sum}");
}

System.Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
SumOtr(array);
Console.ResetColor();
SumPol(array);

