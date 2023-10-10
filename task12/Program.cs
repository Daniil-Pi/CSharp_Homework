/*
Напишите программу, которая будет принимать на вход 2 числа 
и выводить является ли второе число кратным первому,
если второе число не кратно первому, то программа выводит остаток от деления
*/
System.Console.WriteLine("Введите первое число: ");
int First = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int Second = Convert.ToInt32(Console.ReadLine());

if (First % Second == 0)
    System.Console.WriteLine("Второе число кратно первому");
else
    System.Console.WriteLine("Остаток от деления: " + First % Second);