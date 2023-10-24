/*
Числа Фибоначчи
*/

Console.Clear();

System.Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());

int Fi(int n)
{
    if (n == 0)
    return 0;
    if (n == 1)
    return 1;
    else
    return Fi(n-1) + Fi(n-2);
}

for (int i = 0; i <= numb; i++)
{
    System.Console.WriteLine($"{i}! = {Fi(i)}");
}