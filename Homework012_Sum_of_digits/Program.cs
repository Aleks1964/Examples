// ** Задача 27. **
// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

Console.Write("Введите число A: ");                   //Ввод числа А с клавиатуры
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Сумма цифр в числе {A} равна {Summ(A)}");

int Summ(int numb1)
{
    int sum1 = 0;
    string number2 = Convert.ToString(numb1);
    for (int i = 0; i < number2.Length; i++)
    {
        //int numAA = Convert.ToInt32(number2[i]) - 48;  //48 - номер начала цифр в Unicode
        //int numAA = (int)Char.GetNumericValue(Convert.ToChar(number2[i]));
        int numAA = int.Parse((Convert.ToChar(number2[i])).ToString());
        sum1 = sum1 + numAA;
    }
    return sum1;
}

// int Summ(int numb1)
// {
//     int sum1 = 0;
//     while (numb1 > 0)
//     {
//         int numAA;
//         numb1 = Math.DivRem(numb1, 10, out numAA);
//         sum1 += numAA;
//     }
//     return sum1;
// }