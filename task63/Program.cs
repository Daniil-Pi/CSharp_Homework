/*
Задайте n, напишите программу, которая выведет все натуральные числа в промежутке от 1 до n
*/

Console.Clear();

System.Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

void InputNumbers(int n, int start)
{
    if (start <= n)
    {
        System.Console.Write(start + " ");
        start++;
        InputNumbers(n,start);
    }
    else
        return;
}
InputNumbers(n,1);