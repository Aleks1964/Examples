// ** Задача 19

// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом
// (первое число равно последнему, второе равно предпоследнему).

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
string numberStr = number.ToString();

if (numberStr.Length != 5)
{
    Console.WriteLine("Введённое число не является пятизначным");
}
else
{
    if (numberStr[0] == numberStr[4] & numberStr[1] == numberStr[3])
    {
        Console.WriteLine($"Введённое число {numberStr} является палиндромом!");
    }
    else
    {
        Console.WriteLine($"Введённое число {numberStr} НЕ является палиндромом!");
    }
}