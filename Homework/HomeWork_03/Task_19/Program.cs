// Напишите метод(-ы), который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Возвращает цифру в позиции position числа num
int numPosition(int num, int position)
{
    int divisor = (int)(Math.Pow(10, position - 1));
    int result = (num / divisor) % 10;
    return result;
}

// функция проверяет, является ли пятизначное число num палиндромом
bool isPalindrom(int num)
{
    return numPosition(num, 1) == numPosition(num, 5) &&
            numPosition(num, 2) == numPosition(num, 4);
}

int num;
Console.Write("Введите пятизначное число: ");
while (!int.TryParse(Console.ReadLine(), out num)) ;

if (isPalindrom(num))
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");
