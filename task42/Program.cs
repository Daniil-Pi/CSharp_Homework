/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное
*/

Console.Clear();

System.Console.Write("Введите десятичное: ");
int numb = int.Parse(Console.ReadLine());

// int Dvoich(int n)
// {
//     int res = 0;
//     int temp = 1;
//     while(n > 0)
//     {
//         res += n % 2 * temp;
//         n /= 2;
//         temp *= 10;
//     }
//     return res;
// }

//System.Console.WriteLine($"{numb} в двоичной сс равна:{Dvoich(numb)}");


void Dvoich(int n)
{
    string res = "";
    int temp = 1;
    for (int i = numb; i > 0; i/=2)
    {
        temp = i % 2;
        res = temp + res;
        
    }
    System.Console.WriteLine(res);
}

Dvoich(numb);
