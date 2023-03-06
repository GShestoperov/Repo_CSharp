//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a, b, c, max;
Console.Write("Введите три числа: ");
while (!int.TryParse(Console.ReadLine(), out a)) ;
while (!int.TryParse(Console.ReadLine(), out b)) ;
while (!int.TryParse(Console.ReadLine(), out c)) ;

if (a > b)
    max = a;
else
    max = b;
if (c > max)
    max = c;

Console.WriteLine("Max = " + max);
