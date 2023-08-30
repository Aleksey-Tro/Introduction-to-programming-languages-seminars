// // Задача 42: Напишите прорамму, которая будет 
// // преобразовывать десятичное число в двоичное

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// string result = "";

// while (number > 0)
// {
//    result = number % 2 + result;
//    number = number / 2;
// }

// Console.WriteLine(result);


// // Задача 40: Напишите порграмму, которая принимает
// // на вход три числа и проверяет может ли треугольник
// // существовать с длинами сторон чисел

// Console.WriteLine("Введите длину первой стороны: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину первой второй: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину первой третьей: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2)
// {
//    Console.WriteLine("Треугольник с данными длиннами сторон может существовать");
// }
// else
// {
//    Console.WriteLine("Треугольник с данными длиннами сторон не может существовать");
// }


// // Задача 44: не используя рекурсиюб выведите первые числа N чисел
// // Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstNum = 0;
// int secondNum = 1;

// Console.WriteLine(firstNum);
// Console.WriteLine(secondNum);

// for (int i = 2; i < num ; i++)
// {
//    int nextNum = firstNum + secondNum;
//    Console.WriteLine(nextNum);
//    firstNum = secondNum;
//    secondNum = nextNum;
// }


// Задача 39:Напишите программу, которая перевернет
// одномерный массив

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(-10, 11);
   Console.Write(array[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < array.Length / 2; i++)
{
   int n = array[i];
   array[i] = array[array.Length - 1 - i];
   array[array.Length - 1 - i] = n;
}

for (int i = 0; i < array.Length; i++)
{
   Console.Write(array[i] + " ");
}