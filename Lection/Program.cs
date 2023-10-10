System.Console.WriteLine("Введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[n];
      // Создал функцию, которая создает и выводит массив со случайными числами в нем
void List(int[] collection, int N)
{
    for (int i = 0; i < N; i++)
    {
        collection[i] =  new Random().Next(-10, 0);
        System.Console.Write(collection[i] + " ");
    }
}

List(Array, n);

System.Console.WriteLine();

//Создал функцию, которая проверяет наличие, введенноего пользователем числа, в массиве
int F(int[] array, int NUMB)
{
    int result = 0;
    int k = array.Length;
    for (int i = 0; i < k; i++)
    {
        if (array[i] == NUMB)
        {
            result = i;
            break;
        }
    }
    return result;
}

System.Console.WriteLine(F(Array, numb));