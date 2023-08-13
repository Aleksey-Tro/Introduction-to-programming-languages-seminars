// // Задача 24: Напишите программу, которая принимает 
// // на вход число (А) и выдает сумму чисел от 1 до А.
// Console.WriteLine("Введите чило: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Summ()
// {
//    int result = 0;
//    for (int i = 1; i <= number; i++)
//    {
//       result = result + i;
//    }
//    return result;
// }

// Console.WriteLine(Summ());


// Задача 26: Напишите программу, которая принимает на 
// вход число и выдает количество цифр в числе.
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int N()
// {
//    int count = 0;
//    if (number > 0)
//    {
//       while(number > 0)
//       {
//          number = number / 10;
//          count++;
//       }
//    }
//    else
//    {
//       while(number < 0)
//       {
//          number = number / 10;
//          count++;
//       }
//    }
//    return count;
// }

// Console.WriteLine(N());


// // Задача 28: Напишите программу, которая принимает на 
// // вход число N и выдает произведение чисел от 1 до N.

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Num()
// {
//    int result = 1;
//    for (int i = 1; i <= number; i++)
//    {
//       result = result * i;
//    }
//    return result;
// }

// int n = Num();
// Console.WriteLine(n);



// // Задача 30: напишите программу, которая выводит массив из 8 
// // элементов, заполненный нулями и еденицами в случайном порядке.

// int [] array = new int[8];

// void GetArray()
// {
//    for (int i = 0; i < array.Length; i++)
//    {
//       array[i] = new Random().Next(0, 2);
//       Console.Write(array[i] + " ");
//    }
// }

// GetArray();