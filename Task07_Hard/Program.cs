﻿// Задача 7 HARD по желанию - идет за 2 обязательных Напишите программу, которая принимает 
// на вход целое число любой разрядности и на выходе показывает третью цифру слева 
// этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

Console.Clear();
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int result = num;

if (num<100)
    System.Console.WriteLine("Такой цифры нет");
else    
{
    while (num>999)
        {
            num = num / 10;
            // System.Console.WriteLine(num);
        }
        num = num % 10;
        System.Console.WriteLine(num);
}
