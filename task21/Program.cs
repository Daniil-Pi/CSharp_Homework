/*
Внутри класса Answer напишите метод DistanceBetweenPodoubles, 
который принимает на вход координаты двух точек podoubleA и podoubleB
в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.
*/

Console.Clear();

System.Console.WriteLine("Введите x1: ");
double x1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите y1: ");
double y1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите z1: ");
double z1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Введите x2: ");
double x2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите y2: ");
double y2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите z2: ");
double z2 = double.Parse(Console.ReadLine());


System.Console.WriteLine(
    Math.Round(Math.Sqrt(
     Math.Pow((x2 - x1), 2)
     + Math.Pow((y2 - y1), 2)
      + Math.Pow((z2 - z1), 2)), 2));