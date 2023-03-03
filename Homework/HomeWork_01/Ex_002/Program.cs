// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a, b, max;
Console.Write("Введите два числа: ");
while (!int.TryParse(Console.ReadLine(), out a)) ;
while (!int.TryParse(Console.ReadLine(), out b)) ;

if (a > b)
    max = a;
else
    max = b;

Console.WriteLine("Max = " + max);
