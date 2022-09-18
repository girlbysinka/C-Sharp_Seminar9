/*Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""*/
Console.Clear();

string NumbersRec(int m, int n)
    {
        if (m <= n) return NumbersRec(m + 1, n) + $"{m} ";
        else return String.Empty;
    }

Console.WriteLine(NumbersRec(1, 10));