// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrix(int m, int n)
{
    return new int[m, n];
}

void FillMatrix(int[,] matrix)
{
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.Next(0, 10);
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

void OutputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " ");
        Console.WriteLine();
    }
}

int FindMinSumMatrixRows(int[,] matrix)
{
    int minSumRowIndex = 0;
    int minSumRow = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            sumRow += matrix[i, j];
        if (sumRow < minSumRow || i == 0)
        {
            minSumRow = sumRow;
            minSumRowIndex = i;
        }
    }
    return minSumRowIndex;
}

int m = 4, n = 4;
int[,] matrix = CreateMatrix(m, n);
FillMatrix(matrix);
Output("Исходная матрица: ");
OutputMatrix(matrix);
int minSumRowIndex = FindMinSumMatrixRows(matrix);
Output("Минимальная сумма элементов у строки " + (minSumRowIndex + 1));