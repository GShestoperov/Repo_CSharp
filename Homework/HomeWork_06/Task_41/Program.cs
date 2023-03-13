// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] CreateArray(int length)
{
    return new int[length];
}

void InputArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Элемент {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int GreaterNullCount(int[] arr)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            result++;
    }

    return result;
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

int M = 5;
int[] arr = CreateArray(M);
Output("Введите массив: ");
InputArray(arr);
Output($"В массиве больше нуля {GreaterNullCount(arr)} элементов");
