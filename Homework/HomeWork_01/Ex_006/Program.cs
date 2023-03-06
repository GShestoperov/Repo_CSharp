// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int a;
Console.Write("Введите число: ");
while (!int.TryParse(Console.ReadLine(), out a)) ;

if (a % 2 == 0)
    Console.WriteLine("Число четное");
else
    Console.WriteLine("Число нечетное");
