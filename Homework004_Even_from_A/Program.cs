// ** Задача 8
// ** Напишите программу, которая на вход принимает число (N),
// ** на выходе показывает все чётные числа от 1 до N.


// Если мы получаем случайное число:

//int numberA = new Random().Next(1, 10);
//Console.Write("Число А = ");
//Console.WriteLine(numberA);

//Если мы вводим число в программе:

//int numberA = 5;

//Если мы вводим число в терминале:

Console.Write("Введите число А = ");
int numberA = Convert.ToInt32(Console.ReadLine());

int count = 2;

while (count <= numberA)
{
    Console.Write($"{count}, ");
    count = count + 2;
}