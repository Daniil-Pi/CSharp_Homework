/*Определение строки с наименьшей суммой элементов
Исходная матрица:
9   1   7   
1   2   3   
4   5   6   

Сумма наименьшей строки (строка 2): 6
Сумма элементов в строке 2: 6
*/

using System;

public class Answer
{
    public static int SumOfRow(int[,] matrix, int row)
    {
// Введите свое решение ниже
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[row, i];
        }
        return sum;
    }

    public static int[] MinimumSumRow(int[,] matrix)
    {
// Введите свое решение ниже
        int[] result = new int[2];
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == 0)
                sum1 += matrix[i,j];
                if (i == 1)
                sum2 += matrix[i,j];
                if (i == 2)
                sum3 += matrix[i,j];
            }

            if (i == 2)
            {
                if (sum1 <= sum2 && sum1 <= sum3)
                {
                    System.Console.WriteLine("!!!!");
                result[0] = 0;
                result[1] = sum1;
                break;
                }
                if (sum2 <= sum1 && sum2 <= sum3)
                {
                    System.Console.WriteLine("!!!!");
                result[0] = 1;
                result[1] = sum2;
                break;
                }
                if (sum3 <= sum1 && sum3 <= sum2)
                {
                    System.Console.WriteLine("!!!!");
                result[0] = 2;
                result[1] = sum3;
                break;
                }
            }
        }
        return result;
    }

 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
          // Если аргументы не переданы, используем матрицу по умолчанию
            
            matrix = new int[,]
            {
                {9, 5, 3},
                {9, 6, 2},
                {7, 6, 5}

            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        int[] minSumRow = MinimumSumRow(matrix);

        Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

        int rowToSum = 1; 
        int sum = SumOfRow(matrix, rowToSum);
        Console.WriteLine($"Сумма элементов в строке {rowToSum + 1}: {sum}");
    }
}

