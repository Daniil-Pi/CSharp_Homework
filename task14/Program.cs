/*
Напишите программу, которая принимает на вход число, и 
проверяет кратно ли оно одновременно 7 и 23
*/

System.Console.WriteLine("Введите число: ");
int Numb = Convert.ToInt32(Console.ReadLine());

if (Numb % 7 == 0 && Numb % 23 == 0)
    System.Console.WriteLine("Да, кратно");
else if (Numb % 7 == 0 && Numb % 23 != 0)
    System.Console.WriteLine("Нет, не кратно 23");
else if (Numb % 23 == 0 && Numb % 7 != 0)
    System.Console.WriteLine("Нет, не кратно 7");
else
    System.Console.WriteLine("Нет, не кратно 7 и 23");