/*
0. Напишите программу, которая на вход принимает число и выдает его квадрат
(число умноженное на само себя).
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

number *= number;

System.Console.WriteLine("Ответ: " + number);
