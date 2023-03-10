// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int GetNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void Output(string str)
{
    Console.WriteLine(str);
}

int ThirdDigit(int num)
{
    int x = Math.Abs(num);

    if (x < 100)
        return -1;

    while (x > 999)
        x = x / 10;

    x = x % 10;

    return x;
}

int num = GetNumber("Введите число: ");
int thirdDigit = ThirdDigit(num);
if (thirdDigit == -1)
    Output("Третьей цифры нет");
else
    Output("Третья цифра " + thirdDigit);