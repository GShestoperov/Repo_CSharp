// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int length)
{
    int[] result = new int[length];
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        result[i] = random.Next(0, 10);
    }

    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

int SumOddIndex(int[] arr)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            result += arr[i];
    }

    return result;
}

int[] arr = CreateArray(8);
PrintArray(arr);
Output("Сумма нечетных элементов " + SumOddIndex(arr));
