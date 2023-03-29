//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

int SumNaturalSegment(int M, int N)
{
    if (M <= N)
        return SumNaturalSegment(M + 1, N) + M;
    else
        return 0;
}

int M = InputInt("Введите M: ");
int N = InputInt("Введите N: ");
int sum = SumNaturalSegment(M >= 1 ? M : 1, N);
Output("Сумма натуральных чисел от M до N равна " + sum);