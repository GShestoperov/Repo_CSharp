// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N, i;
Console.Write("Введите N: ");
while (!int.TryParse(Console.ReadLine(), out N)) ;

i = 1;
while (i <= N)
{
    if (i % 2 == 0)
        Console.Write(i + " ");
    i++;
}
