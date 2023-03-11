// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе


int GetNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void Output(string msg)
{
    Console.WriteLine(msg);
}

int SumDigit(int num)
{
    int x = Math.Abs(num);
    int result = 0;

    while (x > 0)
    {
        result += x % 10;
        x /= 10;
    }

    return result;
}

int num = GetNumber("Введите число: ");
Output("Сумма цифр " + SumDigit(num));
