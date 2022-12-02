// Задача 41
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

// [0, 7, 8, -2, 2] -> 2
// [1, -7, 567, 89, 223] -> 4

//Ввод массива из M элементов
Console.Write($"Введите с клавиатуры несколько чисел через пробел (в конце - Enter): ");

int[] n = Console.ReadLine().Split(new char[] { '.', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(e => Convert.ToInt32(e)).ToArray();
//Console.WriteLine(String.Join(", ", n));

Console.WriteLine($"Вы ввели {ArrayNeg(n)} чисел строго больше 0");

// ------------ Методы ---------------
// Метод подсчёта отрицательных значений в массиве ArrayNeg
int ArrayNeg(int[] arrayA)
{
    int sum = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if (arrayA[i] > 0)
        {
//           Console.Write(arrayA[i]);
            sum++;
//            Console.WriteLine($", sum = {sum}");
        }
    }
    return sum;
}