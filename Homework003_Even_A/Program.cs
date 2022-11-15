// ** Задача 6
// ** Напишите программу, которая на вход принимает число и выдаёт,
// ** является ли число чётным (делится ли оно на два без остатка).

// Если мы получаем случайное число:

//int numberA = new Random().Next(1, 10);
//Console.Write("Число А = ");
//Console.WriteLine(numberA);

//Если мы вводим число в программе:

//int numberA = 3;

//Если мы вводим число в терминале:

Console.Write("Введите число А = ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0)
{
    Console.Write($"Ура, число {numberA} - чётное! ДА");
}
else
{
    Console.Write($"Увы, число {numberA} - НЕ чётное! НЕТ");
}