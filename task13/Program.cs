/*
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
*/

System.Console.WriteLine("Введите число: ");
int Numb = Convert.ToInt32(Console.ReadLine());
int j = 0;
int CountNumb = Numb;

while (CountNumb != 0)
{
    CountNumb = CountNumb / 10;
    j++;
}


if (j==3)
    System.Console.WriteLine(Numb%10);


else if (j>3)
{
    for (int i=j; i>3; i--)
    {
       Numb = Numb / 10;
    }
    System.Console.WriteLine(Numb%10);
}


else
    System.Console.WriteLine("Нет третьей цифры");
