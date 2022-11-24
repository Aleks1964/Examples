// ** Задача 29. **
// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

//Ввод массива из N=8 элементов:
int N = 8;
int[] array1 = RandArray(N);

//Вывод массива на экран:
Console.WriteLine();
Console.WriteLine($"Массив: [{String.Join(", ", array1)}]");

//Метод вывода массива RandArray:
int[] RandArray(int N)
{
    int[] arrayN = new int[N];
    for (int i = 0; i < N; i++)
    {
        arrayN[i] = new Random().Next(0, 10);
        //Console.WriteLine(array2[i]);
    }
    return arrayN;
}