// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int length)
{
    return new int[length];
}

void FillArray(int[] array)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] array = CreateArray(8);
FillArray(array);
PrintArray(array);
