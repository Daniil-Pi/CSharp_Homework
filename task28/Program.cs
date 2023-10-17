/*
Напишите программу, которая принимает на вход число N и выдает произведение чисел от одного до N
*/

Console.Clear();

System.Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());

int fact(int numb)
{
    if (numb != 0)
    {
        int result = 1;
        for (int i = 2; i <= numb; i++)
        result *= i;

        return result;
    }
    else
    {
        int result = 0;
        return result;
    }
}

System.Console.WriteLine($"Факториал равен: {fact(numb)}");