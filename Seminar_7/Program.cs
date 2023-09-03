// // Задача 46: Задайте двумерный массив размером MxN,
// // заполненный случайными целыми числами

// int[,] matrix = new int[3, 4];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       matrix[i, j] = new Random().Next(-10, 11);
//       Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
// }


// // Задача 48: Задайте двумерный массив размерами m на n, 
// // каждый элемент в массиве находится по формуле Amn=m+n. 
// // Выведите полученный массив

// int[,] matrix = new int[3, 4];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       matrix[i, j] = i + j;
//       Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
// }



// // Задача 49: Задайте двумерный массив. Найдите элементы, 
// // у которых, оба индекса четные, и замените эти элементы 
// // на их квадраты

// int[,] matrix = new int[4, 4];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       matrix[i, j] = new Random().Next(-10, 11);
//       if (i % 2 == 0 && j % 2 == 0)
//       {
//          matrix[i, j] = new Random().Next(-10, 11);
//       }
//       Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
// }

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       if (i % 2 == 0 && j % 2 == 0)
//       {
//          matrix[i, j] = matrix[i, j] * matrix[i, j];
//       }
//       Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
// }



// // Задача 51: Задайте двумерный массив. 
// // Найдите сумму элементов, находящихся на главной диагонали

// int[,] matrix = new int[4, 4];
// int result = 0;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//       matrix[i, j] = new Random().Next(-10, 11);
//       if (i == j)
//       {
//          result += matrix[i, j];
//       }
//       Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
// }

// Console.WriteLine(result);