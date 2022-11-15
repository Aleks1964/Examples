// ** Задача 2 **

// ** Напишите программу,
// ** которая на вход принимает два числа и выдаёт, 
// ** какое число большее, а какое меньшее.

//Если мы получаем случайные числа:

//int numberA = new Random().Next(1, 10);
//Console.Write("Число А = ");
//Console.WriteLine(numberA);
//int numberB = new Random().Next(1, 10);
//Console.Write("Число B = ");
//Console.WriteLine(numberB);

//Если мы вводим числа в программе:

// int numberA = 5;
// int numberB = 7;

//Если мы вводим числа в терминале:

Console.Write("Введите число А = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B = ");
int numberB = Convert.ToInt32(Console.ReadLine());

int maxAB = numberA;
if (numberA < numberB) maxAB = numberB;
Console.Write($"Максимальное число {maxAB}");