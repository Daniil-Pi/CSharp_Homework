/*
Среднее арифметическое каждого столбца
*/

// Console.Clear();

// System.Console.Write("Введите высоту массива: ");
// int n = int.Parse(Console.ReadLine());
// System.Console.Write("Введите ширину массива: ");
// int m = int.Parse(Console.ReadLine());
// System.Console.Write("Введите число, на которое увеличивается каждый новый элемент массива: ");
// int k = int.Parse(Console.ReadLine());

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             System.Console.Write(matrix[i,j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }
  
// int[,] CreateIncreasingMatrix(int n, int m, int k)
// {
//     int[,] matrix = new int[n,m];
//     matrix[0,0] = 1;
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             if (i == 0 && j == 0)
//             continue;
//             else
//             {
//                 if (j == 0)
//                     matrix[i,j] = matrix[i-1,m-1] + k;
//                 else
//                     matrix[i,j] = matrix[i, j-1] + k;
//             }
//         }
//     }
//     return matrix;
// }

// double[] FindAverageInColumns (int[,] arr)
// {
//     double[] SrAr = new double[arr.GetLength(1)];
//     int temp = 0;
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             temp += arr[i,j];
//         }
//         SrAr[j] = temp/arr.GetLength(0);
//         temp = 0;
//     }
//     return SrAr;
// }

// void PrintSr(double[] arr)
// {
//     foreach (double i in arr)
//     {
//         System.Console.Write($"{i:f2}\t");
//     }
// }

// int[,] MainArray = CreateIncreasingMatrix(n,m,k);
// PrintArray(MainArray);
// double[] SrAr = FindAverageInColumns(MainArray);
// PrintSr(SrAr);

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }

    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
    int[,] matrix = new int[n,m];
    int temp = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
           matrix[i,j] = temp;
           temp += k;
        }
    }
    return matrix;

    }
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
 foreach (double i in list)
    {
        System.Console.Write($"{i:f2}\t");
    }

    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
    double[] SrAr = new double[matrix.GetLength(1)];
    double temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp += matrix[i,j];
        }
        SrAr[j] = temp/matrix.GetLength(0);
        temp = 0;
    }
    return SrAr;

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        System.Console.WriteLine("The averages in columns are:");
        PrintListAvr(FindAverageInColumns(result));
    }
}