/*
 Напишите программу, которая принимает на вход трёхзначное число и 
 на выходе показывает вторую цифру этого числа.
*/

int numb = new Random().Next(100, 1000);
System.Console.WriteLine("Случайное число - " + numb);

System.Console.WriteLine((numb/10)%10);