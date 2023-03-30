﻿/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

using System;
using static System.Console;

Clear();
Write("Задайте значение N: ");
int n = int.Parse(ReadLine());
WriteLine(PrintNumbers(n));

string PrintNumbers(int n)
{
    if (n == 1)
    {
        return "1";
    }
    string s = n.ToString() + " " + PrintNumbers(n - 1);
    //WriteLine(s);
    return s;
}