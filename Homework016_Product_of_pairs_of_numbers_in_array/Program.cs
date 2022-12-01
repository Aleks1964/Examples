// Задача 37
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//Ввод массива из N элементов

//int N = 10;

// Console.Write("Введите число N (число элементов массива): ");
// int N = int.Parse(Console.ReadLine()!);

// int[] array1 = RandArray(N);

int[] array1 = new int[] { 1, 2, 3, 4, 5 };

int NNew = LangthArray(array1);
int[] array2 = ProductArray(array1, NNew);

//Вывод массивов на экран
//Console.WriteLine();
Console.WriteLine($"Исходный массив: [{String.Join(", ", array1)}]");
Console.WriteLine($"Новый массив (с произведением пар): [{String.Join(", ", array2)}]");

// ------------ Методы ---------------
// Метод заполнения массива произвольными значениями RandArray
//int[] RandArray(int[] arrayA, int N)
//{
//    int[] arrayN = new int[N];
//    for (int i = 0; i < N; i++)
//    {
//        arrayN[i] = new Random().Next(-1000, 1000);
//    }
//    return arrayN;
//}

// Метод определения размера нового массива LangthArray
int LangthArray(int[] arrayAA)
{
    int lengthAA = arrayAA.Length;
    int lengthNN = 0;
    if (lengthAA % 2 == 1)
    {
        lengthNN = lengthAA / 2 + 1;
    }
    else
    {
        lengthNN = lengthAA / 2;
    }
    return lengthNN;
}

// Метод перемножения пар элементов массива ProductArray
int[] ProductArray(int[] arrayAAA, int lengthNew)
{
    int[] arrayNew = new int[lengthNew];

    for (int i = 0; i < lengthNew; i++)
    {
        arrayNew[i] = arrayAAA[i] * arrayAAA[arrayAAA.Length - 1 - i];
        Console.WriteLine($"arrayNew[{i}] = {arrayNew[i]},");
    }

    if (arrayAAA.Length % 2 == 1)
        arrayNew[lengthNew - 1] = arrayAAA[lengthNew - 1];
    return arrayNew;
}