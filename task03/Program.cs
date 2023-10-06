/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру
*/

string[] weekDays = {"Понедельник", "Вторник", "Среда", "Четверг", 
"Пятница", "Суббота", "Воскресенье"};

System.Console.WriteLine("Введите номер: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (0 < Number && Number < 8)
{
    Number --;
    System.Console.WriteLine(weekDays[Number]);
}

else
System.Console.WriteLine("Такого дня недели нет");
