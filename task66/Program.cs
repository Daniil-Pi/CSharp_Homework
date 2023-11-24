/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Clear();

System.Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());
System.Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

int Summ(int m, int n)
{
    if (m != n)
    {
        return m + Summ(m+1,n);
    }
    else
    {
        return m;
    }
}

int result = Summ(M, N);
System.Console.WriteLine($"M = {M}; N = {N} -> {result}");