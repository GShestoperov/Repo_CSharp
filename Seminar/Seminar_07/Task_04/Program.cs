// Задача 4: Найти произведение двух матриц. 
// https://www.webmath.ru/poleznoe/formules_6_6.php

// Проверка результатов сложения и умножения: https://ru.onlinemschool.com/math/assistance/matrix/multiply/

int[,] CreateMatrix(int m, int n)
{
    return new int[m, n];
}

void FillArray(int[,] matrix, int m, int n)
{
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rand.Next(0, 10);
}

void OutputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j],4}");
        Console.WriteLine();
    }
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

int[,] MatrixMultiply(int[,] matrA, int[,] matrB)
{
    int m = matrA.GetLength(0);
    int n = matrA.GetLength(1);
    int k = matrB.GetLength(1);
    int[,] result = new int[m, k];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < k; j++)
        {
            int sum = 0;
            for (int l = 0; l < n; l++)
            {
                sum += matrA[i, l] * matrB[l, j];
            }
            result[i, j] = sum;
        }

    return result;
}

int m = 3, n = 2, k = 2;
int[,] matrA = CreateMatrix(m, n);
int[,] matrB = CreateMatrix(n, k);
FillArray(matrA, m, n);
FillArray(matrB, n, k);
Output("Матрица A: ");
OutputMatrix(matrA);
Output("Матрица B: ");
OutputMatrix(matrB);

int[,] matrC = MatrixMultiply(matrA, matrB);
Output("Матрица C = A * B: ");
OutputMatrix(matrC);

