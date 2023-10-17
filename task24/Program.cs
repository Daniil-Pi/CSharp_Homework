/*
Напишите программу, которая принимает на вход число "а" и выдает сумму чисел от одного до "а"
*/

Console.Clear();

System.Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int Summ(int A)
{
    int result = 0;
    for (int i = 0; i <= A; i++)
    {
        result += i;
    }
    return result;
}

System.Console.WriteLine($"Ответ: {Summ(a)}");