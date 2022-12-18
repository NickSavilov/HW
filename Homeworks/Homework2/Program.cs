// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//  int secondNum(int num)
// {
//     int des = num%100;
//     int ed = des%10;
//     return (des-ed)/10;
// }
// Console.WriteLine("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = secondNum (number);
// Console.WriteLine ($"Второе число вашего числа {number} это {result}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int ThNum(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет, ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int length = number.ToString().Length;
// Console.Write(ThNum(number, length));

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// bool kratnost(int num)
// { 
//     if (num>5&&num<8)
//     {
//         return true;
//         }
//         else
//         return false;
// }
// Console.WriteLine("Введите цифру обозначающую день недели");
// int num = Convert.ToInt32(Console.ReadLine());
// bool result = kratnost(num);
// Console.WriteLine(result);