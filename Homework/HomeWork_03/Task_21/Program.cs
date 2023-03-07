// Напишите метод(-ы), который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double length2Point(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

double x1, y1, z1, x2, y2, z2, l;
Console.Write("Введите координаты первой точки (x1, y1, z1) (через Enter): ");
x1 = double.Parse(Console.ReadLine());
y1 = double.Parse(Console.ReadLine());
z1 = double.Parse(Console.ReadLine());
Console.Write("Введите координаты второй точки (x2, y2, z2) (через Enter): ");
x2 = double.Parse(Console.ReadLine());
y2 = double.Parse(Console.ReadLine());
z2 = double.Parse(Console.ReadLine());

l = length2Point(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Расстояние между двумя точками равно " + l);
