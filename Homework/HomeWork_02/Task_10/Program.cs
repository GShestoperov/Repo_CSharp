// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int GetNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void Output(string str)
{
    Console.WriteLine(str);
}

int SecondDigit(int num)
{
    return Math.Abs((num / 10) % 10);
}

int num = GetNumber("Введите трехзначное число: ");
Output("Вторая цифра " + SecondDigit(num));
