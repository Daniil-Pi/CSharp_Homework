/*
Напишите прорамму, которая будет принимать на вход число и возвращать сумму его цифр
*/
Console.Clear();

System.Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

int Summ(int n)
{
    if (n > 0)
    {
        return n % 10 + Summ(n/10);
    }
    else
    {
        return 0;
    }
}

int result = Summ(n);
System.Console.WriteLine(result);