/*
Напишите программу, которая выводит случайное трехзначное число
 и удаляет вторую цифру этого числа
*/

int numb = new Random().Next(100, 1000);
System.Console.WriteLine("Случайное число - " + numb);

int Result = ((numb / 100)*10 + numb % 10);
System.Console.WriteLine(Result);


