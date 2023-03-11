//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

int Pow(int A, int B)
{
    if (B == 0)
        return 1;

    int result = A;
    for (int i = 2; i <= B; i++)
    {
        result *= A;
    }
    return result;
}

int A, B;
A = GetNumber("Введите число A: ");
B = GetNumber("Введите число B: ");
B = Math.Abs(B);
Output($"Pow({A}, {B}) = {Pow(A, B)}");