// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GenerateArray(int m, int n)
{
    int[,] result = new int[m, n];
    Random rand = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = rand.Next(0, 10);

    return result;
}

void OutputArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j],2} ");
        Console.WriteLine();
    }
}

int InputNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

bool GetElement(int[,] array, int y, int x, out int value)
{
    if (y >= 0 && y < array.GetLength(0) &&
        x >= 0 && x < array.GetLength(1))
    {
        value = array[y, x];
        return true;
    }
    else
    {
        value = 0;
        return false;
    }
}

int m = 10;
int n = 10;
int[,] array = GenerateArray(m, n);
OutputArray(array);
int y = InputNumber("Введите позицию элемента (номер строки): ");
int x = InputNumber("Введите позицию элемента (номер столбца): ");
int value;
if (GetElement(array, y, x, out value))
    Output("На этой позиции элемент " + value);
else
    Output("Такой позиции в массиве нет");
