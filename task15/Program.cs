/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
*/

System.Console.WriteLine("Введите число: ");
int Numb = Convert.ToInt32(Console.ReadLine());

if (Numb == 6 || Numb == 7)
    System.Console.WriteLine("Да");
else
    System.Console.WriteLine("Нет");