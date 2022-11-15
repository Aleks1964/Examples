// ** Задача 4
// ** Напишите программу, которая принимает на вход три числа
// ** и выдаёт максимальное из этих чисел.

// Если мы получаем случайные числа:

//int numberA = new Random().Next(1, 10);
//Console.Write("Число А = ");
//Console.WriteLine(numberA);
//int numberB = new Random().Next(1, 10);
//Console.Write("Число B = ");
//Console.WriteLine(numberB);
//int numberC = new Random().Next(1, 10);
//Console.Write("Число C = ");
//Console.WriteLine(numberC);

//Если мы вводим числа в программе:

// int numberA = 24;
// int numberB = 12;
// int numberC = 7;

//Если мы вводим числа в терминале:

Console.Write("Введите число А = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B = ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C = ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.Write("Максимальное число = ");
        Console.WriteLine(numberA);
    }
    else
    {
        Console.Write("Максимальное число = ");
        Console.WriteLine(numberC);
    }
}
else
{
    if (numberB > numberC)
    {
        Console.Write("Максимальное число = ");
        Console.WriteLine(numberB);
    }
    else
    {
        Console.Write("Максимальное число = ");
        Console.WriteLine(numberC);
    }
}