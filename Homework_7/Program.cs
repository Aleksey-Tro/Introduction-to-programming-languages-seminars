// // Задача 47. Задайте двумерный массив размером m×n,
// // заполненный случайными вещественными числами.

// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9

// double[,] matrix = new double[4, 4];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       matrix[i, j] =new Random().Next(-10, 11) - new Random().NextDouble();
//       Console.Write(matrix[i, j] +" ");
//    }
//    Console.WriteLine();
// }



// // Задача 50. Напишите программу, которая на вход принимает 
// // позиции элемента в двумерном массиве, и возвращает значение 
// // этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

// int[,] matrix = new int[4, 4];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       matrix[i, j] = new Random().Next(-10, 11);
//       Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
// }

// void Search()
// {
//    Console.WriteLine("Введите позицию элемента: ");
//    int n = Convert.ToInt32(Console.ReadLine());
//    int n1 = n / 10;
//    int n2 = n % 10;
//    if (n1 < 4 && n1 > -1 && n2 > -1 && n2 < 4)
//    {
//       Console.WriteLine(matrix[n1, n2]);
//    }
//    else
//    {
//       Console.WriteLine(n + " -> Данной позиции нет в массиве");
//    }
// }

// Search();



// // Задача 52. Задайте двумерный массив из целых чисел. 
// // Найдите среднее арифметическое элементов в каждом столбце.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] matrix = new int[2, 3];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       matrix[i, j] = new Random().Next(-10, 10);
//       Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
// }

// Console.WriteLine();

// void Average()
// {

//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       decimal average = 0;
//       for (int i = 0; i < matrix.GetLength(0); i++)
//       {
//          average = (average + matrix[i, j]);
//       }
//       average = average / (matrix.GetLength(0));
//       Console.Write(average + " ");
//    }
// }

// Average();