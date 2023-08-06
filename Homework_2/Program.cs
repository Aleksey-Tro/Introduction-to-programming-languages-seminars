// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Помимо генерации случайного числа Добавил для ввода 
// пользователя, но пользователь может ввести любое число

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// int number1 = (number / 10) % 10;
// Console.WriteLine(number1);


// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Помимо генерации случайного числа Добавил для ввода 
// пользователя, но пользователь может ввести любое число

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int number = new Random().Next(1, 100000);
// Console.WriteLine(number);

// if(number > 99 && number < 1000)
// {
//    Console.WriteLine($"Третья цифра числа {number} -> {number % 10}");
// }
// else if(number > 999 && number < 10000)
// {
//    Console.WriteLine($"Третья цифра числа {number} -> {(number / 10) % 10}");
// }
// else if(number > 10000 && number < 100000)
// {
//    Console.WriteLine($"Третья цифра числа {number} -> {(number / 100) % 10}");
// }
// else if(number < 100)
// {
//    Console.WriteLine($"Третьей цифры в введенном числе нет");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// // int number = new Random().Next(1, 8);
// // Console.WriteLine(number);

// if(number > 5 && number < 8)
// {
//    Console.WriteLine("Да, данный день недели является выходным");
// }
// else if(number < 6)
// {
//    Console.WriteLine("Нет, данный день недели, является буднями");
// }
// else if(number > 7)
// {
//    Console.WriteLine("Такого дня недели не существует");
// }