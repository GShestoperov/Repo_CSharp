//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int GetNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void Output(string str)
{
    Console.WriteLine(str);
}

bool isHoliday(int num)
{
    if (num == 6 || num == 7)
        return true;
    else
        return false;
}

int num = GetNumber("Введите число, обозначающее день недели: ");
if (isHoliday(num))
    Output("Ура, сегодня выходной! Всем гулять)");
else
    Output("Увы, сегодня не выходной");
