// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Первое решение
// Console.WriteLine("Введите положительное пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [5];

// if(number > 9999 && number < 100000)
// {
//    for(int i = 4; i >= 0; i--)
//    {
//    array[i] = number % 10;
//    number = number / 10;
//    }
//    if(array[0] == array[4] && array[1] == array[3])
//    {
//       Console.WriteLine($"является палиндромом");
//    }
//    else
//    {
//       Console.WriteLine("не является палиндромом");
//    }
// }
// else
// {
//    Console.WriteLine($"ОШИБКА: введите пятизначное число");
// }



// Второе решение
// Console.WriteLine("Введите положительное пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int number1 = number % 10;
// number = number / 10;
// int number2 = number % 10;
// number = number / 10;
// int number3 = number % 10;
// number = number / 10;
// int number4 = number % 10;
// number = number / 10;
// int number5 = number % 10;

// if(number1 == number5 && number2 == number4)
// {
//    Console.WriteLine("Да");
// }
// else
// {
//    Console.WriteLine("Нет");
// }



// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату X точки А");
// int X1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y точки А");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Z точки А");
// int Z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X точки B");
// int X2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y точки B");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Z точки B");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// double number = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2-Y1), 2) + Math.Pow((Z2-Z1), 2));
// Console.WriteLine(number);



// Задача 23
// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= number; i++)
// {
//    Console.WriteLine(Math.Pow(i, 3));
// }