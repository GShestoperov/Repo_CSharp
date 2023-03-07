// Напишите метод(-ы), который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string TableCube(int N)
{
    string result;
    int i, cube;
    result = "";
    i = 1;
    while (i <= N)
    {
        cube = i * i * i;
        if (i > 1)
        {
            result += ", ";
        }
        result += cube;
        i++;
    }
    return result;
}

int N;
Console.Write("Введите N: ");
N = int.Parse(Console.ReadLine());

string outStr;
outStr = TableCube(N);
Console.WriteLine("Таблица кубов: " + outStr);
