/*
Напишите программу, которая находит сумму элементов с нечетными индексами 
в одномерном массиве целых чисел и выводит результат на экран.
*/

public class Answer
{
    public static int SumOddElements(int[] array)
    {
        // Введите свое решение ниже
        int Sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                Sum += array[i];
            }
        
        }
        return Sum;


    }

    public static void PrintArray(int[] array)
    {
         // Введите свое решение ниже
            for (int i = 0; i < array.Length; i++)
        {  
            if (i == array.Length - 1)
            System.Console.Write(array[i]);
            else
            System.Console.Write(array[i] + "\t");
        }
        System.Console.WriteLine();

    }


// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}