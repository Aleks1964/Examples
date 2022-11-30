// ** Задача 34. **
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//Ввод массива из N элементов:
//int N = 10;
Console.Write("Введите число N (число элементов массива): ");
int N = int.Parse(Console.ReadLine()!);
int[] array1 = RandArray(N);

//Вывод массива на экран:
Console.WriteLine();
Console.WriteLine($"Массив: [{String.Join(", ", array1)}]");
Console.WriteLine($"Количество чётных чисел в массиве равно {СountArray(array1)}");

// ------------ Методы ---------------
//Метод ввода массива RandArray:
int[] RandArray(int N)
{
    int[] arrayN = new int[N];
    for (int i = 0; i < N; i++)
    {
        arrayN[i] = new Random().Next(100, 1000);
        //Console.WriteLine(array2[i]);
        //Console.WriteLine($"Массив: [{arrayN[i] % 2}]");
    }
    return arrayN;
}

// Метод подсчёта количества чётных элементов массива:
int СountArray(int[] arrayA)
{
    int count = 0;
    // for (int i = 0; i < arrayA.Length; i++)
    //     if (arrayA[i] % 2 == 0) count++;
    foreach (int i in arrayA)
       if (i % 2 == 0) count++;
    return count;
}