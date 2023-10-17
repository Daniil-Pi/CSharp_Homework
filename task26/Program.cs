/*
Напишите программу, которая принимает на вход число и выдает количество цифр в числе
*/

Console.Clear();

System.Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());

int digits(int numb)
{
    int result = 0;
    if (numb == 0)
    {
        result = 1;
        return result;
    }
    else
    {
        for (int i = 1; numb != 0; numb /= 10)
        {
            result ++;
        }
        return result;
    }
}

System.Console.WriteLine($"Количество цифр: {digits(numb)}");