/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 
и выдаёт номер четверти плоскости, в которой находится эта точка.
x=34; y=-30 -> 4 
x=2; y=4-> 1
x=-34; y=-30 -> 3
*/

Console.Clear();

System.Console.WriteLine("Введите координату X: ");
int x = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Y: ");
int y = int.Parse(Console.ReadLine());


if (x > 0 && y > 0)
    System.Console.WriteLine("Находится в 1 четверти");
else if (x < 0 && y > 0)
    System.Console.WriteLine("Находится во 2 четверти");
else if (x < 0 && y < 0)
    System.Console.WriteLine("Находится в 3 четверти");
else if (x > 0 && y < 0)
    System.Console.WriteLine("Находится в 4 четверти");
else
    System.Console.WriteLine("Точка находится на оси координат");