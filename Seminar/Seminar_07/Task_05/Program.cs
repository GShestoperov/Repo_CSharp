// Задача 5: Показать треугольник Паскаля.
// Прказать его в прямоугольной форме
// 1
// 1 1
// 1 2 1
// 1 3 3 1
// 1 4 6 4 1

// * Прказать его в равнобедренной форме (хотя бы 20 строк)

// (a+b)^2 = 

//     1                                    
//    1 1                                    
//   1 2 1                                    
//  1 3 3 1                                    
// 1 4 6 4 1                                    

// ** Показать разложение многочлена m-ой степени при помощи треугольника

// *** Показать треугольник Паскаля в виде


//     *                                    
//    * *                                    
//   *   *                                    
//  * * * *                                    
// *       *

// НО показывайте "*" только если соответствующий коэф треугольника нечетный 

// Хотя бы для 100 строк


int[,] CreateArray(int m, int n)
{
    return new int[m, n];
}

void FillPascalTriangle(int[,] array)
{
    int n = array.GetLength(0);

    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = 0;

    if (n >= 1)
        array[0, 0] = 1;
    if (n >= 2)
    {
        array[1, 0] = 1;
        array[1, 1] = 1;
    }

    for (int i = 2; i < n; i++)
    {
        array[i, 0] = 1;
        array[i, i] = 1;
        for (int j = 1; j < n - 1; j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
}

void OutputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] != 0)
            {
                if (array[i, j] < 1000)
                    Console.Write($"{array[i, j],5}");
                else if (array[i, j] < 1000000)
                    Console.Write($"{array[i, j] / 1000,4}K");
                else if (array[i, j] < 1000000000)
                    Console.Write($"{array[i, j] / 1000000,4}M");
            }
            else
                Console.Write("     ");
        Console.WriteLine();
    }
}

void Output(string msg)
{
    Console.WriteLine(msg);
}


int[,] MakeIsoscelesTriangle(int[,] array)
{
    int n = array.GetLength(1);
    int l = 2 * n - 1;
    int[,] result = new int[n, l];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < l; j++)
            result[i, j] = 0;

        int jIndex = (l / 2) - (i);
        int stopIndex = (l / 2) + (i);
        int k = 0;
        while (jIndex <= stopIndex)
        {
            result[i, jIndex] = array[i, k];
            jIndex += 2;
            k++;
        }
    }

    return result;
}


// Количество строк в треугольнике
int n = 13;
int[,] pascalArr = CreateArray(n, n);

FillPascalTriangle(pascalArr);
Output("Треугольник Паскаля в прямоугольной форме: ");
OutputArray(pascalArr);

int[,] pascalIsoscelesArr = MakeIsoscelesTriangle(pascalArr);
Output("Треугольник Паскаля в равнобедренной форме: ");
OutputArray(pascalIsoscelesArr);

