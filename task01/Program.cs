/*
1. Напишите программу, которая на вход принимает два числа и проверяет,
 является ли первое число квадратом второго.
*/

System.Console.WriteLine("Введите первое число: ");
int OneNumb = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int SecNumb = Convert.ToInt32(Console.ReadLine());

if (OneNumb == SecNumb * SecNumb)
System.Console.WriteLine($"Да, число {OneNumb} является квадратом числа {SecNumb}");
else
System.Console.WriteLine($"Нет, число {OneNumb} не является квадратом числа {SecNumb}");