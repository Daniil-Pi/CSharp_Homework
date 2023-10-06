/*
Напишите программу, которая на вход принимает одно число N, 
а на выходе показывает все целые числа в промежутке от -N до N
*/

System.Console.WriteLine("Введите число: ");
int Numb = Convert.ToInt32(Console.ReadLine());

if (Numb >= 0)
{
for (int i = Numb * (-1); i <= Numb; i++)
    {
       System.Console.Write(i + " ");
    }
}

else 
{
    for (int i = Numb; i <= Numb * (-1); i++)
    {
    System.Console.Write(i + " ");
    }
}