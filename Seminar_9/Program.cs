// // Задача 63: Задайте значение N. Напишите программу, которая
// // выведет все натуральные числа в промежутке от 1 до N

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int i = 1;

// int Number(int number)
// {
//    if (number >= i)
//    {
//       Console.Write(i + " ");
//       i++;
//       Number(number);
//    }
//    return number;
// }

// string Number(int start, int end)
// {
//    if (start == end)
//    {
//       return start.ToString();
//    }
//    return (start + " " + Number(start + 1, end));
// }

// Console.WriteLine(Number(1, number));



// Задание 65: Задайте значения M и N. Напишите программу, 
// которая выведет все числа от N до M

// Console.WriteLine("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// string Number(int start, int end)
// {
//    if (start == end)
//    {
//       return start.ToString();
//    }
//    return (start + " " + Number(start + 1, end));
// }

// if (number1 < number2)
// {
//    Console.WriteLine(Number(number1, number2));
// }
// else
// {
//    Console.WriteLine("Введите правильную пару чисел ");
// }




// // Задагие 67: Напишите программу которая будет принимать 
// // на вход число и возвращать сумму его цифр. 

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Number(int number)
// {
//    if (number <= 0)
//    {
//       return 0;
//    }
//    return (number % 10 + Number(number / 10));
// }

// Console.WriteLine(Number(number));



// // Задача 69: Напишите программу, которая принимает на 
// // вход два числа и возводит первое число и возводит его 
// // в степень второго числа

// Console.WriteLine("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// double Number(int number1, int number2)
// {
//    if (number2 == 0)
//    {
//       return 1;
//    }
//    else
//    {
//       return (number1 * Number(number1, number2 -1));
//    }
// }

// Console.WriteLine(Number(number1, number2));