﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
System.Console.Write("Введите 1ое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите 2ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите 3ое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2>max) max = num2;
if (num3>max) max = num3;
    System.Console.WriteLine($"max = {max}");

