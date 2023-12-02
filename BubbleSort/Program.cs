Console.Clear();
System.Console.Write("Введите размер массива: ");
int len = int.Parse(Console.ReadLine());

int[] arr = new int[len];

void InputArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,11);
    }
}

void Bubble(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length-1; i++)
    {

        for (int j = 0; j < arr.Length-1-i; j++)
        {
            if (arr[j+1] < arr[j])
            (arr[j], arr[j+1]) = (arr[j+1], arr[j]);
            count++;
        }
    }
    System.Console.WriteLine("1!!" + count);
}

InputArr(arr);
System.Console.WriteLine($"Исходный массив: [{String.Join(", ", arr)}]");
Bubble(arr);
System.Console.WriteLine($"Конечный массив: [{String.Join(", ", arr)}]");
System.Console.WriteLine("Если че 'O' большое тут равно: O((n^2/2)");
