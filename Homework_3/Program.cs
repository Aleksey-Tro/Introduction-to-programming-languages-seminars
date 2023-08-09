// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Первое решение
Console.WriteLine("Введите положительное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
int number2 = 0;

int [] array1 = new int[5];

for (int i = 4; i >= 0; i--)
{
   array1[i] = number % 10;
   number = number / 10;
   Console.Write(array1[i]);
}
for(int i = 4; i > 0; i--)
{
   number2 = number2 * 10;
   number2 = number2 + array1[i];
}
Console.Write(number2);

