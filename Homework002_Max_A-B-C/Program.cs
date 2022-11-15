//int numberA = new Random().Next(1, 10);
//Console.Write("Число А = ");
//Console.WriteLine(numberA);
//int numberB = new Random().Next(1, 10);
//Console.Write("Число B = ");
//Console.WriteLine(numberB);
//int numberC = new Random().Next(1, 10);
//Console.Write("Число C = ");
//Console.WriteLine(numberC);
int numberA = 24;
int numberB = 12;
int numberC = 7;
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