﻿// Задача 1: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите числа m и n:");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

int result = Ackerman(m,n);
Console.Write($"Результат функции Аккермана: {result}");

int Ackerman(int m, int n)
{
    if (m == 0) return n+1;
    else if (m > 0 && n == 0) return Ackerman (m-1,1);
    else return Ackerman(m-1,Ackerman(m,n-1));
}