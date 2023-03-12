// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] CreateArray(int length)
{
    double[] result = new double[length];
    Random rand = new Random();

    for (int i = 0; i < length; i++)
    {
        result[i] = rand.Next(0, 30);
    }

    return result;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double FindMax(double[] arr)
{
    if (arr.Length == 0)
        return 0;

    double result = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > result)
            result = arr[i];
    }

    return result;
}

double FindMin(double[] arr)
{
    if (arr.Length == 0)
        return 0;

    double result = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < result)
            result = arr[i];
    }

    return result;
}

double DifferenceMaxMin(double[] arr)
{
    return FindMax(arr) - FindMin(arr);
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

double[] arr = CreateArray(10);
PrintArray(arr);
Output("Разница между максимальным и минимальным элементом " + DifferenceMaxMin(arr));
