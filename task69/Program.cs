/*
Напишите программу, которая на вход принимает два числа: a и b, и возводит число a в степень b с помощью рекурсии
*/
Console.Clear();

System.Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());

int Pow(int a, int b)
{
    if (b > 1)
    {
        return a * Pow(a,b-1);
    }
    else
    {
        return a;
    }
}

int res = Pow(a,b);
System.Console.WriteLine(res);