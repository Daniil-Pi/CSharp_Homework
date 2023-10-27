/*
Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y=k1 * x + b1, y=k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем 
*/

Console.Clear();

System.Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
System.Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
System.Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
System.Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());

double x = 1;


x = (b1 -(b2)) / (-1*(k1 - (k2)));
System.Console.WriteLine($"X = {Math.Round(x,2)}");

double y = 1;
y = k2 * x + b2;
System.Console.WriteLine($"Y = {Math.Round(y,2)}");