// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//int[] arr = { -1, -2, 5, 4, 11, 10, -3, -8, 14 };
int[] arr = { 6, 7, 3, 6 };

int resLength;
if (arr.Length % 2 != 0)
    resLength = arr.Length / 2 + 1;
else
    resLength = arr.Length / 2;
int[] resArr = new int[resLength];

for (int i = 0; i < resLength; i++)
{
    if (i == (resLength - 1) && arr.Length % 2 != 0)
        resArr[i] = arr[i];
    else
        resArr[i] = arr[i] * arr[arr.Length - 1 - i];
}
PrintArray(arr);
Console.WriteLine("");
PrintArray(resArr);
