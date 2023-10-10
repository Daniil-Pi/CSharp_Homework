/*
Напишите программу, которая принимает на вход два числа,
 и проверяет является ли одно число квадратом другого
*/

System.Console.WriteLine("Введите первое число: ");
int First = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int Second = Convert.ToInt32(Console.ReadLine());

if (First*First == Second)
    System.Console.WriteLine("Второе число является квадратом первого");
else if (Second*Second == First)
    System.Console.WriteLine("Первое число является квадратом второго");
else
    System.Console.WriteLine("Нет");