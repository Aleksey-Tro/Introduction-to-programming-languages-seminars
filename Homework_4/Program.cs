// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int Result()
// {
//    int result = 1;

//    for (int i = 0; i < number2; i++)
//    {
//       result = result * number1;
//    }
//    return result;
// }

// Console.WriteLine(Result());


// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Sum()
// {
//    int numberA = 0;
//    int result = 0;
//    if(number > 0)
//    {
//       while(number > 0)
//       {
//          numberA = number % 10;
//          number = number / 10;
//          result = result +numberA;
//       }
//    }
//    else
//    {
//       while(number < 0)
//       {
//          numberA = number % 10;
//          number = number / 10;
//          result = result +numberA;
//       }
//    }
//    return result;
// }

// int a = Sum();
// Console.WriteLine(a);



// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// // Первое решение
// int [] array = new int[8];

// void GetArray()
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       array[i] = new Random().Next(-2, 3);
//       if(array[i] != 0) // 0 убираем из списка, так как массив изначально заполнен ими
//       {
//          Console.Write(array[i] + " ");
//       }
//    }
// }

// GetArray();


// // Второе решение, только оно будет заполнять массив в обратном
// // порядке, и принимать не больше восьмизначного числа

// Console.WriteLine("Введите восьмизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[8];

// int Array()
// {
//    int i = 0;
//    if(number > 0)
//    {
//       while(number > 0 && number < 99999999)
//       {
//       array[i] = number % 10;
//       number = number / 10;
//       Console.Write(array[i] + " ");
//       i++;
//       }
//    }
//    else if(number == 0)
//    {
//       Console.WriteLine("Массив и так заполнен 0, введите другое число");
//    }
//    else
//    {
//       while(number < 0 && number > -99999999)
//       {
//       array[i] = number % 10;
//       number = number / 10;
//       Console.Write(array[i] + " ");
//       i++;
//       }
//    }
//    return number;
// }

// Console.WriteLine(Array());