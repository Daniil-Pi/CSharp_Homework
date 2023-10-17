/*
Напишите программу. которая принимает на вход число и вдает сумму цифр в числе
*/

Console.Clear();

System.Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());

int sum(int numb)
{
    int result = 0;
    for (int i=0; numb != 0; numb/=10)
    {
        result += numb % 10;
    }
    return result;
}

System.Console.WriteLine(sum(numb));