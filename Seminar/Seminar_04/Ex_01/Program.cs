// Задача* На вход подаётся массив 0 и 1 представляющий двоичное число
// * Написать программу, получающую из этого представления десятичное число

// [1,1,1] -> 7
// [1,0,1,0,0] ->20
// [1,1,1,0] -> 14

int ConvertArrayToInt(int[] array)
{
    int multiplier = 1;
    int result = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result += multiplier * array[i];
        multiplier *= 2;
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintMsg(string msg)
{
    Console.WriteLine(msg);
}

int[] array = { 1, 1, 1, 0 };
PrintMsg("Двоичный формат: ");
PrintArray(array);
int num = ConvertArrayToInt(array);
PrintMsg("Десятичное число: " + num);

