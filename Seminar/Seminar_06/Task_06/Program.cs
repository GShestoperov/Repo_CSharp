// Написать программу сложения двух матриц

int[,] generateMaxtrix(int m, int n)
{
    int[,] result = new int[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rand.Next(0, 10);
        }
    }

    return result;
}

void printMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void output(string msg)
{
    Console.WriteLine(msg);
}

int[,] calcSumMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] result = new int[matrixA.GetLength(0), matrixA.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            result[i, j] = matrixA[i, j] + matrixB[i, j];
        }
    }

    return result;
}

int m = 2, n = 3;
int[,] matrixA = generateMaxtrix(m, n);
int[,] matrixB = generateMaxtrix(m, n);

output("Матрица А: ");
printMatrix(matrixA);
output("Матрица B: ");
printMatrix(matrixB);

int[,] matrixSum = calcSumMatrix(matrixA, matrixB);
output("Матрица C=A+B: ");
printMatrix(matrixSum);
