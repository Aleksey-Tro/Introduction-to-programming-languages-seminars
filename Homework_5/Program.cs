// // Задача 34: Задайте массив заполненный случайными 
// // положительными трёхзначными числами. Напишите программу,
// // которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива:");
// int len = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[len];
// int result = 0;

// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = new Random().Next(100, 1000);
//    Console.Write(array[i] + " ");
//    if(array[i] % 2 == 0)
//    {
//       result++;
//    }
// }

// Console.WriteLine();
// Console.WriteLine(result);



// // Задача 36: Задайте одномерный массив, заполненный
// //  случайными числами. Найдите сумму элементов, 
// //  стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива:");
// int len = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[len];
// int result = 0;

// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = new Random().Next(-10, 10);
//    Console.Write(array[i] + " ");
//    if (i % 2 == 1)
//    {
//       result = result + array[i];
//    }
// }

// Console.WriteLine();
// Console.WriteLine(result);


// // Задача 38: Задайте массив вещественных чисел.
// // Найдите разницу между максимальным и 
// // минимальным элементов массива.
// // [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



// Console.WriteLine("Введите размер массива:");
// int len = Convert.ToInt32(Console.ReadLine());

// double[] array = new double[len];
// double result = 0;

// double max = 0;
// double min = 0;

// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = new Random().Next(-10, 10) + new Random().NextDouble(); // можно было использовать Random rand = new Random();
//    Console.Write(array[i] + " ");
//    if (array[i] > max) max = array[i];
//    else if (array[i] < min) min = array[i];
//    result = max - min;
// }

// Console.WriteLine(result);

