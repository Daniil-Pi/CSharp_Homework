Console.Clear();
System.Console.Write("Введите размер массива: ");
int len = int.Parse(Console.ReadLine());

int[] array = new int[len];

void InputArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10,6);
    }
}

void SelectSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int min = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[min])
                min = j;
        }
        (array[min], array[i]) = (array[i], array[min]);
    }
}

InputArr(array);
System.Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");
SelectSort(array);
System.Console.WriteLine($"Конечный массив: [{String.Join(", ", array)}]");