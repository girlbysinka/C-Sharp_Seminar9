/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18*/
Console.Clear();

string SumEvenNumbersRec(int sum, int m, int n)
    {
        if (m <= n && m%2 == 0) return SumEvenNumbersRec(sum + m, m + 1, n);
        else if (m <= n) return SumEvenNumbersRec(sum, m + 1, n);
        else return $"{sum}"; 
    }

Console.WriteLine(SumEvenNumbersRec(0, 1, 29));