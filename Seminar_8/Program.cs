// // Задача 53: Задайте двумерный массивю Напишите программу,
// // которая поменяет местами первую и последнюю строку массива

// void FillArray(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          matrix[i, j] = new Random().Next(-10, 11);
//       }
//    }
// }

// void PrintArray(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          Console.Write(matrix[i, j] + " ");
//       }
//       Console.WriteLine();
//    }
// }

// void Reverse(int[,] matrix, int length)
// {
//    int[] temp = new int[length];
//    for (int i = 0; i < temp.Length; i++)
//    {
//       temp[i] = matrix[matrix.GetLength(0)-1, i];
//       matrix[matrix.GetLength(0)-1, i] = matrix[0, i];
//       matrix[0, i] = temp[i];
//    }
// }

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// FillArray(matrix);
// PrintArray(matrix);

// Console.WriteLine();

// Reverse(matrix, columns);
// PrintArray(matrix);


// // Задача 55: Задайте двумерный массив. Напишите программу,
// // которая заменяет строки на столбцы. В случае, если это
// // невозможно, программа должна вывести сообщение для пользователя.

// Console.WriteLine("Задайте количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Задайте количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];
// int[,] matrix1 = new int[matrix.GetLength(0), matrix.GetLength(1)];

// void FillMatrix(int[,] matrix)
// {
//    if (rows == columns)
//    {
//       for (int i = 0; i < matrix.GetLength(0); i++)
//       {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//          {
//             matrix[i, j] = new Random().Next(-9, 10);
//          }
//       }
//    }
//    else
//    {
//       Console.WriteLine("сообщение пользователю ");
//    }
// }

// void CopyRevers(int[,] matrix, int[,] matrix1)
// // {
// //    for (int i = 0; i < matrix.GetLength(0); i++)
// //    {
// //       for (int j = 0; j < matrix.GetLength(1); j++)
// //       {
// //          matrix1[j, i] = matrix[i, j];
// //       }
// //    }
// // }

// void PrintMatrix(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          Console.Write(matrix[i,j]+" ");
//       }
//       Console.WriteLine();
//    }
// }

// FillMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// CopyRevers(matrix, matrix1);
// PrintMatrix(matrix1);



// // Задача 59: Задайте двухмерный массив из целых чисел.
// // Напишите программу, которая удалит строку и столбец,
// // на пересечении которых расположен минимальный элемент

// Console.WriteLine("Задайте количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Задайте количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];
// int minElement = int.MaxValue;
// int mini = 0;
// int minj = 0;

// void FillMatrix(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          matrix[i, j] = new Random().Next(-9, 10);
//          if (matrix[i, j] < minElement)
//          {
//             minElement = matrix[i, j];
//             mini = i;
//             minj = j;
//          }
//       }
//    }
// }

// void PrintMatrix1(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       if (i != mini)
//       {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//          {
//             if (j != minj)
//             {
//                Console.Write(matrix[i, j] + " ");
//             }
//          }
//          Console.WriteLine();
//       }
//    }
// }

// void PrintMatrix(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          Console.Write(matrix[i,j]+" ");
//       }
//       Console.WriteLine();
//    }
// }


// FillMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// PrintMatrix1(matrix);


