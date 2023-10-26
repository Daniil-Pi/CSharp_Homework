/*
Вывести числа Фибоначчи
*/

Console.Clear();

System.Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());

void Fi(int n)
{
    int[] list = new int[n];
    for (int i = 0; i < list.Length; i++)
    {
        if (i == 0)
            list[i] = 0;
        else if (i == 1)
            list[i] = 1;
        else
            list[i] = list[i-1] + list[i-2];
        System.Console.Write(list[i] + " ");
    }
}
Fi(numb);