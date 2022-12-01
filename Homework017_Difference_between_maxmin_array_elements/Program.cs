// Задача 38
// Задайте массив целых чисел от -10 до 10.
// Найдите разницу между максимальным и минимальным элементами массива.

//Ввод массива из N элементов
int N = 10;

// Console.Write("Введите число N (число элементов массива): ");
// int N = int.Parse(Console.ReadLine()!);

int[] array1 = RandArray(N);

// int[] array1 = new int[] {-4, -1, 9, 6};

//Вывод массива на экран
Console.WriteLine();
Console.WriteLine($"Массив: [{String.Join(", ", array1)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {arrayDif(array1)}");

// ------------ Методы ---------------
// Метод заполнения массива произвольными значениями RandArray
int[] RandArray(int N)
{
    int[] arrayN = new int[N];
    for (int i = 0; i < N; i++)
    {
        arrayN[i] = new Random().Next(-10, 11);
    }
    return arrayN;
}

// Метод вычисления разницы между максимальным и минимальным элементами массива arrayDif
int arrayDif(int[] arrayA)
{
    int MinA = arrayA[0];
    int MinAIndex = 0;
    int MaxA = arrayA[0];
    int MaxAIndex = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if (arrayA[i] > MaxA)
        {
            MaxA = arrayA[i];
            MaxAIndex = i;
        }
        else
        {
            if (arrayA[i] < MinA)
            {
                MinA = arrayA[i];
                MinAIndex = i;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент массива = {MinA} является {MinAIndex + 1} элементом массива");
    Console.WriteLine($"Максимальный элемент массива = {MaxA} является {MaxAIndex + 1} элементом массива");
    int DifA = arrayA[MaxAIndex] - arrayA[MinAIndex];
    return DifA;
}