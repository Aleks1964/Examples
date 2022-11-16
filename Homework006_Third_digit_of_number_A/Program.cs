// ** Задача 13
// ** Программа, которая выводит третью цифру заданного числа
// ** или сообщает, что третьей цифры нет.
// ** Берем числа до 100000

// Если мы получаем случайное число:

// int numberA = new Random().Next(0, 100000);
// Console.WriteLine($"Число А = {numberA}");

// string numberAA = numberA.ToString();
// Console.WriteLine($"Третья цифра числа A: {numberAA[2]}");

//Если мы вводим число в программе:

//string numberA = 456;

//Если мы вводим число в терминале:

Console.Write("Введите число А = ");
string numberA = Console.ReadLine()!;

if(numberA.Length < 3)
{
   Console.Write($"Увы, число А = {numberA} содержит меньше 3-х знаков");
}
else
{
   Console.WriteLine($"Третья цифра числа A: {numberA[2]}");
}