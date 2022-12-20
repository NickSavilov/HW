// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// void five (int num)
// {
//     int n1 = num/10000;
//     int n2 = num/1000%10;
//     int n4 = num%100/10;
//     int n5 = num%10;
//     if (n1==n5 && n2==n4)
//     {
//         Console.WriteLine ("да");
//     }
//     else 
//     {
//         Console.WriteLine ("нет");
//     }
// }

// Console.WriteLine ("Введите пятизначное число");
// int number = Convert.ToInt32 (Console.ReadLine());
// five(number);

// ВТОРОЙ ВАРИАНТ С СОКРАЩЕНИЕМ И РАСШИРЕННЫМ ОТВЕТОМ. 

// void five (int num)
// {
//     if (num/10000==num%10 && num/1000%10==num%100/10)
//     {
//         Console.WriteLine ($"Число {num} полиндром");
//     }
//     else 
//     {
//         Console.WriteLine ($"Число {num} не полиндром");
//     }
// }

// Console.WriteLine ("Введите пятизначное число");
// int number = Convert.ToInt32 (Console.ReadLine());
// five(number);

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double N (double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double k1 = x2 - x1;
//     double k2 = y2 - y1;
//     double k3 = z2 - z1;
//     double g =Math.Round(Math.Sqrt(k1*k1+k2*k2+k3*k3),2);

// return g ;
// }
// Console.WriteLine("Координаты x1:");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты y1:");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты z1:");
// double z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты x2:");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты y2:");
// double y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Координаты z2:");
// double z2 = Convert.ToInt32(Console.ReadLine());
// double result = N(x1, y1, z1, x2, y2, x2);
// Console.WriteLine(result);

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void cube (int n)

// {
//     for (int i=1; i<=n; i++)
//     {
//         Console.WriteLine ($"{i*i*i}");
//     }
// }
// Console.WriteLine ("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// cube(x);