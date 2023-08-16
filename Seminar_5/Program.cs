// // Задачча 31: Задайте массив из 12 элементов, заполненный 
// // случайными числами из промежутка [-9, 9]. Найдите сумму 
// // отрицательных и положительных элементов массива.

// int [] array = new int[12];

// void GetArray()
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       array[i] = new Random().Next(-9, 10);
//       Console.Write(array[i] + " ");
//    }
// }

// int Summ()
// {
//    int summ = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if(array[i] > 0)
//       summ = summ + array[i];
//    }
//    return summ;
// }

// int NegativeSumm()
// {
//    int negativeSumm = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if(array[i] < 0)
//       {
//          negativeSumm = negativeSumm + array[i];
//       }
//    }
//    return negativeSumm;
// }

// GetArray();
// Console.WriteLine();
// int result1 = Summ();
// int result2 = NegativeSumm();
// Console.WriteLine(Summ());
// Console.WriteLine(NegativeSumm());



// // Задачча 32: Напишите программу замена элементов массива:
// // положительные элементы замените на соответствующие 
// // отрицательные и на оборот.

// Console.WriteLine("Введите размер масива(строго > 0): ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите размер масива(строго > 0): ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int [] array1 = new int[number1];
// int [] array2 = new int[number2];

// void GetArray(int [] length, int [] array)
// {
//    int len = length.Length;
//    for (int i = 0; i < len; i++)
//    {
//       array[i] = new Random().Next(-9, 10);
//       Console.Write(array[i] + " ");
//    }
// }

// int Replace(int [] length, int [] array)
// {
//    int len = length.Length;
//    for (int i = 0; i < len; i++)
//    {
//       array[i] = array[i] * -1;
//       Console.Write(array[i] + " ");
//    }
//    return len;
// }

// GetArray(array1, array1);
// Console.WriteLine();
// Replace(array1, array1);
// Console.WriteLine();
// GetArray(array2, array2);
// Console.WriteLine();
// Replace(array2, array2);

// // Задача 33: Задайте массив. Напишите программу,
// // которая определяет, присутствует ли заданное
// //  число в масиве.

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [30];
// bool isFind = false;

// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = new Random().Next(-99, 100);
//    if(array[i]==number)
//    {
//       isFind = true;
//    }
// }
// if(isFind == true)
// {
//    Console.WriteLine("да");
// }
// else
// {
//    Console.WriteLine("нет");
// }

// // Задача 35: Задайте одномерный массив из 123 элементов 
// // случайных чисел. Найдите количество элементов массива, 
// // значения которых лежат в отрезке [10, 99].


// int[] array = new int[123];

// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = new Random().Next(-99, 100);
// }

// int Section1099()
// {
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//       if (array[i] < 100 && array[i] > 9)
//          sum = sum + 1;
//    }
//    Console.WriteLine(sum);
//    return sum;
// }

// Section1099();



// // Задача 37: Найдите произведение пар чисел в одномерном массиве.
// // Парой считаем первый и последний элементб второй и предпоследний
// //  и т.д. Результат запишите в новом массиве.

// Console.WriteLine("Введите размер массива: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [number];
// int [] result = new int [number / 2 + number % 2];

// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = new Random().Next(-10, 11);
//    Console.Write(array[i] + " ");
// }

// Console.WriteLine();

// for (int j = 0; j < array.Length; j++)
// {
//    int a = array.Length - j -1;
//    result[j] = array[j] * (array[a]);
//    if(j==a)
//    {
//    result[j]=array[j];
//    }
//    Console.Write(result[j] + " ");
// }
