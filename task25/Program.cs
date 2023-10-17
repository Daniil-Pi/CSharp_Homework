/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число А 
в натуральную степень B.
*/

Console.Clear();

System.Console.Write("Введите А: ");
int A = int.Parse(Console.ReadLine());
System.Console.Write("Введите B: ");
int B = int.Parse(Console.ReadLine());

double pow(int a, int b)
{
    double result = 0;
    result = Math.Pow(a, b);
    return result;
}

System.Console.WriteLine(pow(A,B));
