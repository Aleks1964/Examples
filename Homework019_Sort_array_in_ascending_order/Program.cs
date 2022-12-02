// Задача 42
// Написать программу, которая на вход принимает массив 
// из любого количества элементов (не менее 6) 
// в промежутке от 0 до 100, а на выходе выводит этот же массив,
// но отсортированный по возрастанию (от меньшего числа к большему).

//Ввод массива из N элементов
start1:
//int N = 10;

Console.Write("Введите число N - число элементов массива (не менее 6): ");
int N = int.Parse(Console.ReadLine()!);
if (N < 6)
{
    Console.WriteLine($"Число N должно быть не менее 6");
    goto start1;
}
int[] array1 = RandArray(N);

//Вывод массива на экран
Console.WriteLine();
Console.WriteLine($"Исходный массив: [{String.Join(", ", array1)}]");
Console.WriteLine($"Массив, отсортированный по возрастанию: [{String.Join(", ", SortArray(array1))}]");

// ------------ Методы ---------------
// Метод заполнения массива произвольными значениями RandArray
int[] RandArray(int N)
{
    int[] arrayN = new int[N];
    for (int i = 0; i < N; i++)
    {
        arrayN[i] = new Random().Next(0, 100);
    }
    return arrayN;
}

// Метод сортировки массива по возрастанию 
int[] SortArray(int[] arrayA)
{
    //Array.Sort(arrayA);
    for (int i = 0; i < arrayA.Length; i++)
    {
        for (int j = i + 1; j < arrayA.Length; j++)
        {
            if (arrayA[i] > arrayA[j])
            {
                int temp = arrayA[i];
                arrayA[i] = arrayA[j];
                arrayA[j] = temp;
            }
        }
    }
    return arrayA;
}