// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

void OutputNaturalNumber(int N, bool isFirstElement)
{
    if (N == 0) return;

    if (isFirstElement)
        Console.Write(N);
    else
        Console.Write(", " + N);

    OutputNaturalNumber(N - 1, false);
}

int N = InputInt("Введите N: ");
Output("Натуральные числа от N до 1: ");
OutputNaturalNumber(N, true);
