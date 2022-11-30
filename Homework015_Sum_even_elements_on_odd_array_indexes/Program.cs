// ** Задача 36. **
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// Индексы элементов должны быть нечетными - 1,3,5 и т.д.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//Ввод массива из N элементов:

//int N = 10;

// Console.Write("Введите число N (число элементов массива): ");
// int N = int.Parse(Console.ReadLine()!);

// int[] array1 = RandArray(N);

int[] array1 = new int[] {-4, -6, 89, 6};

//Вывод массива на экран:
Console.WriteLine();
Console.WriteLine($"Массив: [{String.Join(", ", array1)}]");
Console.WriteLine($"Сумма элементов массива на чётных позициях равна {arraySumm(array1)}");

// ------------ Методы ---------------
// Метод ввода массива RandArray:
// int[] RandArray(int N)
// {
//     int[] arrayN = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         arrayN[i] = new Random().Next(-1000, 1000);
//     }
//     return arrayN;
// }

// Метод подсчёта суммы элементов, стоящих на нечётных позициях массива
int arraySumm(int[] arrayA)
{
    int sum = 0;
    for (int i = 1; i < arrayA.Length; i = i + 2)
    {
    sum = sum + arrayA[i];
    }
    return sum;
}