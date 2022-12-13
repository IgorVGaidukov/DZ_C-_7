// Задача 50. Напишите программу, которая на вход принимает значение (-позиции) элемента в двумерном массиве, 
// и возвращает позицию (-значение) этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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

Console.Write("Введите значение элемента: ");
var value = int.Parse(Console.ReadLine());

Console.Write("Позиции элемента в массиве: ");

bool noItem = true;

for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        if (value == array[i, j])
        {
            Console.Write($"({i},{j}), ");
            noItem = false;
        }

if (noItem)
    Console.Write($"Нет элемента '{value}' в массиве");