﻿// // Задача 64: Задайте значение N. Напишите программу,
// // которая выведет все натуральные числа в промежутке 
// // от N до 1. Выполнить с помощью рекурсии.
// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int N(int n)
// {
//    if (n > 0)
//    {
//       Console.Write(n +" ");
//       n--;
//       N(n);
//    }
//    return n;
// }

// N(n);



// // Задача 66: Задайте значения M и N. 
// // Напишите программу, которая найдёт 
// // сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// Console.WriteLine("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int MN(int m, int n)
// {
//    int result = 0;
//    if (m < n)
//    {
//       for (int i = m; i <= n; i++)
//       {
//          result += i;
//       }
//    }
//    else
//    {
//       Console.WriteLine("Значение M должно быть меньше значения N ");
//    }
//    Console.WriteLine($"M = {m}; N = {n}; -> {result}");
//    return m;
// }

// MN(m, n);



// // Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// // рекурсии. Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int AckermannFunction(int m, int n)
// {
//    if (m == 0) return n + 1;
//    else if (n == 0) return AckermannFunction(m - 1, 1);
//    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
// }

// Console.WriteLine(AckermannFunction(number1, number2));