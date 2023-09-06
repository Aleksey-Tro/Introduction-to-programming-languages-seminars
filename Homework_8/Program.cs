// // Задача 54: Задайте двумерный массив. Напишите программу,
// // которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix1 = new int[rows, columns];
// int[,] matrix2 = new int[rows, columns];
// int[] mas = new int[columns];


// void FillArray(int[,] matrix1, int[,] matrix2)
// {
//    for (int i = 0; i < matrix1.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix1.GetLength(1); j++)
//       {
//          matrix1[i, j] = new Random().Next(-10, 11);
//          matrix2[i, j] = matrix1[i, j];
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


// int[,] SortArray(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          mas[j] = matrix[i, j];
//       }
//       Array.Sort(mas);
//       Array.Reverse(mas);
//       for (int k = 0; k < matrix.GetLength(1); k++)
//       {
//          matrix[i, k] = mas[k];
//       }
//    }
//    return matrix;
// }

// FillArray(matrix1, matrix2);
// PrintArray(matrix1);
// Console.WriteLine();
// PrintArray(SortArray(matrix2));



// // Задача 56: Задайте прямоугольный двумерный массив.
// // Напишите программу, которая будет находить строку с 
// // наименьшей суммой элементов.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и 
// // выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] matrix = new int[4, 2];
// int min = int.MaxValue;
// int result = 0;


// void FillArray(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          matrix[i, j] = new Random().Next(-9, 10);
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

// void Amount(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       int sum = 0;
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          sum = sum + matrix[i, j];
//       }
//       if (sum < min)
//       {
//          min = sum;
//          result = i + 1;
//       }
//    }
//    Console.WriteLine(result);
// }

// FillArray(matrix);
// PrintArray(matrix);
// Amount(matrix);





// // Задача 58: Задайте две матрицы. Напишите программу, 
// // которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// Console.WriteLine("Введите размерность первого массива: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размерность первого массива: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размерность второго массива: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размерность второго массива: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());

// int[,] matrix1 = new int[rows1, columns1];
// int[,] matrix2 = new int[rows2, columns2];

// if (rows1 == columns2)
// {
//    void FillArray(int[,] matrix)
//    {
//       for (int i = 0; i < matrix.GetLength(0); i++)
//       {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//          {
//             matrix[i, j] = new Random().Next(-9, 10);
//          }
//       }
//    }

//    void PrintArray(int[,] matrix)
//    {
//       for (int i = 0; i < matrix.GetLength(0); i++)
//       {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//          {
//             Console.Write(matrix[i, j] + " ");
//          }
//          Console.WriteLine();
//       }
//    }


//    int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
//    {
//       int[,] matrixOut = new int[rows1, columns2];
//       for (int i = 0; i < matrixOut.GetLength(0); i++)
//       {
//          for (int j = 0; j < matrixOut.GetLength(1); j++)
//          {
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                matrixOut[i, j]+=matrix1[i, k] *matrix2[k, j];
//             }
//          }
//       }
//       return matrixOut;
//    }

//    FillArray(matrix1);
//    PrintArray(matrix1);
//    Console.WriteLine();
//    FillArray(matrix2);
//    PrintArray(matrix2);
//    Console.WriteLine();
//    PrintArray(MatrixMultiplication(matrix1, matrix2));
// }
// else
// {
//    Console.WriteLine("Ошиба, количество строк первого массива должны равняться количеству столбцов второго массива");
// }



// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// TODO:Попытка генерации случайных не похожиш цифр, непонятно почему не работает
// int i1 = 0; // TODO:попытка
// int j1 = 0; // TODO:попытка
// int k1 = 0; // TODO:попытка
// void Rand(int i1, int j1, int k1) // TODO:попытка
// { // TODO:попытка
//    for (int i = i1; i1 > 0; i1--) // TODO:попытка
//    { // TODO:попытка
//       for (int j = j1; j1 > 0; j1--) // TODO:попытка
//       { // TODO:попытка
//          for (int k = k1; k1 > 0; k1--) // TODO:попытка
//          { // TODO:попытка
//             if (matrix[i, j, k] == matrix[i1, j1, k1]) // TODO:попытка
//             { // TODO:попытка
//                Console.WriteLine("(" + i + ")(" + j + ")(" + k + ")"); // TODO:попытка
//                matrix[i1, j1, k1] = new Random().Next(10, 100); // TODO:попытка
//                Rand(i1, j1, k1); // TODO:попытка
//             } // TODO:попытка
//          } // TODO:попытка
//       } // TODO:попытка
//    } // TODO:попытка
// } // TODO:попытка
// void FillArray(int[,,] matrix) // TODO:попытка
// { // TODO:попытка
//    for (int i = 0; i < matrix.GetLength(0); i++) // TODO:попытка
//    { // TODO:попытка
//       for (int j = 0; j < matrix.GetLength(1); j++) // TODO:попытка
//       { // TODO:попытка
//          for (int k = 0; k < matrix.GetLength(2); k++) // TODO:попытка
//          { // TODO:попытка
//             matrix[i, j, k] = new Random().Next(10, 100); // TODO:попытка
//             i1 = i-1; // TODO:попытка
//             j1 = j-1; // TODO:попытка
//             k1 = k-1; // TODO:попытка
//             Rand(i1, j1, k1); // TODO:попытка
//          } // TODO:попытка
//       } // TODO:попытка
//    } // TODO:попытка
//  } // TODO:попытка

// FillArray(matrix);

// int[,,] matrix = new int[2, 2, 2] {
//    {
//       { 22, 33 },
//       { 44, 55}
//    },
//    {
//       { 88, 99},
//       { 66, 77}
//    }
// };

// void PrintArray(int[,,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          for (int k = 0; k < matrix.GetLength(2); k++)
//          {
//              Console.Write($"{matrix[i, j, k]}({i},{j},{k})");
//          }
//             Console.WriteLine();
//       }
//    }
// }

// PrintArray(matrix);




// // Задача 62. Напишите программу, которая заполнит 
// // спирально массив 4 на 4.
// // Например, на выходе получается вот такой массив:
// // 01 02 03 04
// // 12 13 14 05
// // 11 16 15 06
// // 10 09 08 07

// void FillArray(int[,] matrix) // метод заполнения массива по спирали
// {
//     int SizeN = matrix.GetLength(1);
//     int SizeM = matrix.GetLength(0);
//     int SizeN1 = -1;
//     int SizeM1 = -1;
//     int length = matrix.GetLength(1)+matrix.GetLength(0);
//     int i = 0;
//     int j = 0;

//     int n = 1;
//     int m = 0;
//     int temp = 0;
//     int val = 1;
//     for (int k = 0; k < length; k++)
//     {
//         if (n == 1)
//         {
//             while (j < SizeN)
//             {
//                 matrix[i, j] = val;
//                 Console.Write(matrix[i, j] + " ");
//                 val++;
//                 j++;
//             }
//             j--;
//             SizeM--;
//             SizeM1++;
//             i++;
//             temp = n;
//             n = m;
//             m = -temp;
//         }
//         else if (m == -1)
//         {
//             while (i < SizeM)
//             {
//                 matrix[i, j] = val;
//                 Console.Write(matrix[i, j] + " ");
//                 val++;
//                 i++;
//             }
//             i--;
//             SizeN--;
//             SizeN1++;
//             j--;
//             temp = n;
//             n = m;
//             m = -temp;
//         }
//         else if (n == -1)
//         {
//             while (j > SizeN1)
//             {
//                 matrix[i, j] = val;
//                 Console.Write(matrix[i, j] + " ");
//                 val++;
//                 j--;
//             }
//             j++;
//             SizeM--;
//             SizeM1++;
//             i--;
//             temp = n;
//             n = m;
//             m = -temp;
//         }
//         else if (m == 1)
//         {
//             while (i > SizeM1)
//             {
//                 matrix[i, j] = val;
//                 Console.Write(matrix[i, j] + " ");
//                 val++;
//                 i--;
//             }
//             i++;
//             SizeN--;
//             SizeN1++;
//             j++;
//             temp = n;
//             n = m;
//             m = -temp;
//         }
//     }
//     return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] CoilMatrix = new int[5, 5];
// PrintArray(FillArray(CoilMatrix));