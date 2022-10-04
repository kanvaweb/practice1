// Домашнее задание к уроку 1 по C#

// ------------- НАЧАЛО
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2 && num1 >= num3)
    Console.WriteLine($"Число {num1} максимальное");
else if (num2 >= num1 && num2 >= num3)
    Console.WriteLine($"Число {num2} максимальное");
else if (num3 >= num1 && num3 >= num2)
    Console.WriteLine($"Число {num3} максимальное");
// ------------- ОКОНЧАНИЕ

