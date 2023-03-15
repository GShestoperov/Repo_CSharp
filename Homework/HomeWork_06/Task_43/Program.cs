// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int inputNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void calcIntersection(double k1, double b1, double k2, double b2,
                      out double x, out double y)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}

bool checkIntersection(int k1, int b1, int k2, int b2)
{
    return k1 - k2 != 0;
}

void output(string msg)
{
    Console.WriteLine(msg);
}

int k1 = inputNumber("Введите k1: ");
int b1 = inputNumber("Введите b1: ");
int k2 = inputNumber("Введите k2: ");
int b2 = inputNumber("Введите b2: ");

if (!checkIntersection(k1, b1, k2, b2))
    output("Прямые не пересекаются");
else
{
    double x, y;
    calcIntersection(k1, b1, k2, b2, out x, out y);

    output($"Точка пересечения [{x};{y}]");
}