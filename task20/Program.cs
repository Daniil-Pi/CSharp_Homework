/*
Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.Clear();

System.Console.WriteLine("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());

//AB = √(AC2 + BC2)
//AC = xb - xa
//BC = yb - ya

double result;
double AC;
double BC;

AC = x2 - x1;
BC = y2 - y1;
result = Math.Sqrt(AC*AC + BC*BC);

System.Console.WriteLine("Ответ: " + Math.Round(result, 3));