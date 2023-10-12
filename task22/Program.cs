/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Clear();

System.Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());

for (int i=1; i <= numb; i++)
{
    System.Console.Write(i*i +  "    ");
    if (i % 3 == 0)
        System.Console.WriteLine();
}