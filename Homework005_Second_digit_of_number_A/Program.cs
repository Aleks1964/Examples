// ** Задача 10
// ** Программа, которая принимает на вход трёхзначное число
// ** и на выходе показывает вторую цифру этого числа.
// ** Обязательна проверка на ввод чисел
// ** больше/меньше 3-х знаков

// Если мы получаем случайное число:

// int numberA = new Random().Next(100, 1000);
// Console.WriteLine($"Число А = {numberA}");
// Console.WriteLine($"Вторая цифра числа A: {(numberA / 10) % 10}");

//Если мы вводим число в программе:

// int numberA = 918;
// if(numberA < 100 || numberA > 999)
// {
//   Console.Write($"Увы, число {numberA} содержит больше/меньше 3-х знаков");
// }
// else
// {
//   Console.WriteLine($"Вторая цифра числа A (A = {numberA}): {(numberA /10)%10}");
// }

//Если мы вводим число в терминале:

Console.Write("Введите число А = ");
string numberA = Console.ReadLine()!;

if (numberA.Length != 3)
{
   Console.WriteLine();
   Console.WriteLine("Введено неверное число!");
   Console.Write($"Увы, число A = {numberA} содержит больше/меньше 3-х знаков");
}
else
{
   Console.WriteLine();
   Console.WriteLine($"Вторая цифра числа A: {numberA[1]}");
}