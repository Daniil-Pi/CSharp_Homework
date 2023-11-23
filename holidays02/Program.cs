/*
Напишите методы для ввода одномерного массива с клавиатуры и для вывода его содержимого на экран.
*/

Console.Clear();

System.Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] Massive(int size)
{
    int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    System.Console.Write($"Введите элемент массива {i}: ");
    arr[i] = int.Parse(Console.ReadLine());
}
return arr;
}

void printArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

int[] array = Massive(size); 
printArr(array);