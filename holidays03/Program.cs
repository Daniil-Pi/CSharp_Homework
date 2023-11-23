/*
Сформируйте одномерный массив действительных чисел 
как геометрическую последовательность со знаменателем ½, начиная с 1, т.е.: 1,0 0,5 0,25 0,125 и т.д.
*/

Console.Clear();

System.Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите первое число массива: ");
int one = int.Parse(Console.ReadLine());

void GP(int size, double one)
{
    double[] arr = new double[size];
    arr[0] = one;
    for (int i = 1; i < size; i++)
    {
        arr[i] = arr[i-1] * 0.5;
    }
    for (int i = 0; i < size; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

GP(size, one);