// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GenerateArray(int m, int n)
{
    int[,] result = new int[m, n];
    Random rand = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = rand.Next(0, 10);

    return result;
}

void OutputMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j],4}");
        Console.WriteLine();
    }
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

void OutputArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{Math.Round(arr[i], 1),4}");
    }
    Console.WriteLine();
}

double[] AverageValueByColumn(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        result[j] = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            result[j] += matrix[i, j];
        result[j] /= matrix.GetLength(0);
    }
    return result;
}

int m = 3, n = 4;
int[,] matrix = GenerateArray(m, n);
Output("Дана матрица: ");
OutputMatrix(matrix);
double[] averageArr = AverageValueByColumn(matrix);
Output("Средние значения по столбцам: ");
OutputArray(averageArr);