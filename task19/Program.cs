/*
Внутри класса Answer напишите метод IsPalindrome, который принимает на вход
пятизначное число number и проверяет, является ли оно палиндромом.
Метод должен проверить является ли число пятизначным, 
в противном случае - вывести Число не пятизначное и False в следующей строке.
Для остальных чисел вернуть True или False.
*/

Console.Clear();

System.Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());
if (numb >= 10000 && numb < 100000)
{
    int numb2;
    numb2 = numb % 100;
    numb2 = (numb2 % 10) * 10 + (numb2 / 10);
    if ((numb / 1000) == numb2)
        System.Console.WriteLine("True");
    else
        System.Console.WriteLine("False");
}
else
{
    System.Console.WriteLine("Число не пятизначное");
    System.Console.WriteLine("False");
}