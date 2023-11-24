/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.Clear();

System.Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

void InputNumbers(int n)
{
    if (n > 0)
    {
        if (n != 1)
        {
            System.Console.Write($"{n}, ");
            InputNumbers(n-1);
        }
        else
        {
            System.Console.Write(n);
            InputNumbers(n-1);
        }
    }
    else
        return;
}

InputNumbers(N);