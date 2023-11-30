/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
Console.Clear();

System.Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

int Function(int m, int n)
{
    if (m == 0)
    {
        System.Console.WriteLine("n = " + n);
        return n+1;
    }
    else
        if ((m != 0) && (n == 0))
        {
            System.Console.WriteLine($"M={m}, N={n}");
            return Function(m - 1, 1);
        }
        else
        {
            System.Console.WriteLine($"m={m}, n={n}");
            return Function(m - 1, Function(m, n - 1));
        }
}

int result = Function(m,n);
System.Console.WriteLine($"m = {m}; n = {n} -> A(m,n) = {result}");