// Напишите программу, которая выводит случайное число из
// отрезка [10, 99] и показываете наибольшую цифру числа.

// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

// int number = new Random().Next(10, 100);
// Console.WriteLine(number);

// int number1 = number / 10;
// int number2 = number % 10;

// if(number1 > number2)
// {
//    Console.WriteLine("Большоее число "+ number1); //Канкатинация
// }
// else
// {
//    Console.WriteLine($"Большоее число {number2}" ); //Интерполяция
// }


// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// int number1 = number / 100;
// int number2 = number % 10;

// int number3 = (number1 * 10) + number2;
// Console.WriteLine(number3);


//Напишите программу, которая будет принимать на вход
// два числа и выводить, является ли второе число кратное первому.
// Если число не кратно числу 1, то программа выводит 
// остаток от деления
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// int number1 = new Random().Next(1, 10);
// int number2 = new Random().Next(10, 100);
// Console.WriteLine(number1);
// Console.WriteLine(number2);

// if(number2 % number1 == 0)
// {
//    Console.WriteLine($"{number1} {number2} -> Кратно");
// }

// else
// {
//    int number3 = number2 % number1;
//    Console.WriteLine($"{number1}, {number2} -> Не кратно {number3}");
// }

// else
// {
//    Console.WriteLine($"{number1}, {number2} -> Не кратно остаток {number2 % number1}");
// }


// Напишите программу, которая принимает на входи число 
// и проверяет, кратно ли оно одновременнои 7 и 23

// int number = new Random().Next(1, 1000);
// Console.WriteLine(number);

// if((number % 7 == 0) && (number % 23 == 0))
// {
//    Console.WriteLine("Число кратно 7 и 23");
// }
// else
// {
//    Console.WriteLine("Число не кратно 7 и 23");
// }


// Console.WriteLine("Введите число");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1 == number2 * number2)
// {
//    Console.WriteLine("да");
// }
// else
// {
//    Console.WriteLine("нет");
// }