/*
Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) 
и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
*/

Console.Clear();

System.Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());

for (int i=1; i <= numb; i++)
{
    System.Console.Write(Math.Pow(i, 3) +  "    ");
    if (i % Math.Round(Math.Sqrt(numb)) == 0)
        System.Console.WriteLine();
}