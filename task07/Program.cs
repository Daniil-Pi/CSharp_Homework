/*
Напишите программу, которая принимает на вход трехзначное число 
и на выходе показывает последнюю цифру этого числа
*/

System.Console.WriteLine("Введите число: ");
int Numb = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Последняя цифра - " + Numb % 10);