/*
Напишите программу, которая выводит случайное число из отрезка 10-99 
и показывает наибольшую цифру числа
*/
int k = new Random().Next(10, 100);
System.Console.WriteLine("Случайное число - " + k);

if ((k / 10) > (k % 10))
    System.Console.WriteLine(k/10);
else if ((k / 10) < (k % 10))
    System.Console.WriteLine(k%10);
else
    System.Console.WriteLine("Числа равны");