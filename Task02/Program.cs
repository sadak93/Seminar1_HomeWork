// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
System.Console.Write("Введите 1ое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите 2ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
    System.Console.WriteLine($"max = {num1}");
else if (num2>num1)
    System.Console.WriteLine($"max = {num2}");
else 
    System.Console.WriteLine("Они равны");