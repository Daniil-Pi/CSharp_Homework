/*
Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины
*/

Console.Clear();

System.Console.Write("Введите 1-е число: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Введите 2-е число: ");
int b = int.Parse(Console.ReadLine());
System.Console.Write("Введите 3-е число: ");
int c = int.Parse(Console.ReadLine());

void test(int a, int b, int c)
{
    if ((a + b <= c) || (a + c <= b) || (c + b <= a))
        System.Console.WriteLine("Такого треугольника не существует");
    else
        System.Console.WriteLine("Такой треугольник существует");
}

test(a,b,c);