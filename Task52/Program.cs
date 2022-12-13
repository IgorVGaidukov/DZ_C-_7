// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива: ");
var rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
var columns = int.Parse(Console.ReadLine());

int[,] GetArrayMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArrayMatrix(rows, columns, 0, 9);

PrintArray(array);

Console.Write("Среднее арифметическое столбцов: ");

double sum;

for (int i = 0; i < columns; i++)
    {
        sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum += array[j, i];
        }
        sum /= rows;
        
        Console.Write($"{sum}");
        if (i < columns-1) Console.Write("; ");

    }