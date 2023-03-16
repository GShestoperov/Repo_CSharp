// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GenerateArray(int m, int n)
{
    double[,] result = new double[m, n];
    Random rand = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = Math.Round(rand.NextDouble() * 20 - 10, 1);

    return result;
}

void OutputArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j],4} ");
        Console.WriteLine();
    }
}

int m = 3;
int n = 4;
double[,] array = GenerateArray(m, n);
OutputArray(array);
