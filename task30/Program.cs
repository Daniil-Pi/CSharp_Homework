/*
Напишите программу, которая выводит массив из 8 элементов,
 заполненный нулями и единицами в случайном порядке
*/

void Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] =  new Random().Next(0, 2);
        System.Console.Write(array[i] + " ");
    }
}

Array(8);


