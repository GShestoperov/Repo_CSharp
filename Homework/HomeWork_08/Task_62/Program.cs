// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrix(int m, int n)
{
    return new int[m, n];
}

void FillMatrix(int[,] matrix, int n, int indent = 0, int start = 1)
{
    if (n < 2) return;
    int value = start;

    for (int j = indent; j <= indent + n - 1; j++)
    {
        matrix[indent, j] = value;
        value++;
    }
    for (int i = indent + 1; i <= indent + n - 1; i++)
    {
        matrix[i, indent + n - 1] = value;
        value++;
    }
    for (int j = indent + n - 2; j >= indent; j--)
    {
        matrix[indent + n - 1, j] = value;
        value++;
    }
    for (int i = indent + n - 2; i >= indent + 1; i--)
    {
        matrix[i, indent] = value;
        value++;
    }

    FillMatrix(matrix, n - 2, indent + 1, value);
}

void OutputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],3}");
        Console.WriteLine();
    }
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

int n = 4;
int[,] matrix = CreateMatrix(n, n);
FillMatrix(matrix, n);
Output("Сгенерированная матрица: ");
OutputMatrix(matrix);
