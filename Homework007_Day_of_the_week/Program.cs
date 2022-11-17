// ** Задача 15
// ** Программа, которая принимает на вход цифру,
// ** обозначающую день недели, и проверяет,
// ** является ли этот день выходным.
// ** Обязательна проверка на ввод числа <1 и >8

// Если мы получаем случайное число:

// int numberA = new Random().Next(1, 8);
// Console.WriteLine($"Число А = {numberA}");

// if(numberA == 6 || numberA == 7)
// {
//    Console.WriteLine("Да, это выходной день!");
// }
// else
// {
//    Console.WriteLine("Это рабочий день");
// }

//Если мы вводим число в программе:

//string numberA = 2;

//Если мы вводим число в терминале:

Console.Write("Введите число, обозначающее день недели = ");
int numberA = Convert.ToInt32(Console.ReadLine());

if(numberA <1 || numberA > 8)
{
   Console.WriteLine("Вы ввели неверное число дней недели (необходимо ввести число от 1 до 7 включительно).");
}
else
{
   if(numberA == 6 || numberA == 7)
   {
      Console.WriteLine("Ура, это выходной день!!!");
   }
   else
   {
      Console.WriteLine("Это рабочий день");
   }
}