// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

long Akkerman(long m, long n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = InputInt("Введите неотрицательное целое m: ");
int n = InputInt("Введите неотрицательное целое n: ");
long result = Akkerman(m, n);
Output($"Akkerman({m}, {n}) = {result}");
