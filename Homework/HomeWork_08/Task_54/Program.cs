// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortRowMatrixDesc(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxIndex = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
                if (matrix[i, k] > matrix[i, maxIndex])
                    maxIndex = k;
            if (maxIndex != j)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, maxIndex];
                matrix[i, maxIndex] = temp;
            }
        }
    }

}

int m = 4, n = 4;
int[,] matrix = CreateMatrix(m, n);
FillMatrix(matrix);
Output("Исходная матрица: ");
OutputMatrix(matrix);
SortRowMatrixDesc(matrix);
Output("Отсортированная по строкам матрица (по убыванию): ");
OutputMatrix(matrix);
