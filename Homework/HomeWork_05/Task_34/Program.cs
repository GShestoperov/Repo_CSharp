// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArray(int length)
{
    int[] result = new int[length];
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        result[i] = random.Next(100, 999);
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

int EvenCount(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            result++;
    }
    return result;
}

int[] arr = CreateArray(10);
PrintArray(arr);
Output("Количество четных элементов: " + EvenCount(arr));
