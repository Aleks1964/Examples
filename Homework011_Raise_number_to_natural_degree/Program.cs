// ** Задача 25. **
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B (степень в которую будем возводить число А): ");
int B = int.Parse(Console.ReadLine()!);

int Raise(int number1, int number2)
{
    int raise1 = 1;
    for (int i = 1; i <= number2; i++)
    {
        raise1 = raise1 * number1;
    }
    return raise1;
}

Console.WriteLine();
Console.WriteLine($"Число {A} в степени {B} равно {Raise(A, B)}");