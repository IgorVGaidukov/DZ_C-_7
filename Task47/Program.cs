// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк массива: ");
var rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] GetArrayMatrix(int rows, int columns, int minValue, int maxValue)
{
    double[,] result = new double[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(minValue,maxValue) + rnd.NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            // Console.Write($"{inArray[i, j]} ");
            Console.Write("{0:0.00} ", inArray[i, j]);
        }
        Console.WriteLine();
    }
}

double[,] array = GetArrayMatrix(rows, columns, 0, 9);

PrintArray(array);