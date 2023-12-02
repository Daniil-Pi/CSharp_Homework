/*
[3, -10, 0, 2, -1, 9, 4, 5, 3]
pivot = 3
[-10, 0, 2, -1] + [3, 3] + [9, 4, 5]

[-10, 0, 2, -1]
pivot = -10
[] + [-10] + [0, 2, -1]

[0, 2, -1]
pivot = 0
[-1] + [0] + [2]


[9, 4, 5]
pivot = 9
[4, 5] + [9] + []


[4, 5]
pivot = 4
[] + [4] + [5]



[-10] + [-1] + [0] + [2] + [3, 3] + [4] + [5] + [9]
*/


int[] quickSort(int[] array, int leftIndex, int rightIndex)
{
    Console.WriteLine($"[{string.Join(", ", array)}]\nleftIndex={leftIndex}\nrightIndex={rightIndex}");
    int i = leftIndex, j = rightIndex, pivot = array[leftIndex];
    System.Console.WriteLine("pivot = " + pivot + "\n");
    while (i <= j){
        while (array[i] < pivot){
            i++;
        }
        while (array[j] > pivot){
            j--;
        }
        if (i <= j){
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }
    System.Console.WriteLine("j = " + j);
    System.Console.WriteLine("i = " + i);
    if (leftIndex < j)
    {   
        System.Console.WriteLine("Первый случай");
        quickSort(array, leftIndex, j);
    }
    if (i < rightIndex)
    {
        System.Console.WriteLine("Второй случай");
        quickSort(array, i, rightIndex);
    }
    System.Console.WriteLine("Третий случай");
    return array;
}

Console.Clear();
int[] array = {3, -10, 4};

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.ResetColor();
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", quickSort(array, 0, array.Length - 1))}]");