// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// void Fill2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("");
//         Console.WriteLine("");
//     }
// }

// Console.Write("Введите количество строк  ");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[linesVol, columnsVol];
// Fill2DArray(numbers);
// Print2DArray(numbers);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int[,]Create2DRandomArray(int rows, int columns, int MinValue, int MaxValue)
// {
//     int[,] newarray = new int [rows,columns];
//     for (int i=0; i<rows; i++)
//     {
//         for (int j = 0; j<columns; j++)
//         {
//             newarray [i,j] = new Random().Next(MinValue, MaxValue+1);
//         }
//     }
//     return newarray;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//            Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// void FindElement(int[,]array, int pos1, int pos2)
// {
//     if (pos1 < 0 | pos1 > array.GetLength(0) - 1 | pos2 < 0 | pos2 > array.GetLength(1) - 1)
// {
//     Console.WriteLine("Элемент не существует  ");
// }
// else
// {
//     Console.WriteLine("Значение элемента массива = {0}", array[pos1, pos2]);
// }
// }
// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray(myArray);
// Console.Write("Введите строку: ");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец: ");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;    
// FindElement (myArray, pos1, pos2);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,]Create2DRandomArray(int rows, int columns, int MinValue, int MaxValue)
// {
//     int[,] newarray = new int [rows,columns];
//     for (int i=0; i<rows; i++)
//     {
//         for (int j = 0; j<columns; j++)
//         {
//             newarray [i,j] = new Random().Next(MinValue, MaxValue+1);
//         }
//     }
//     return newarray;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j = 0; j<array.GetLength(1); j++)
//         {
//            Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }
// void Mean (int[,] array, int b, int a)
// {
// for (a = 0; a < array.GetLength(1); a++)
// {
//     double sum = 0;
//     for (b = 0; b < array.GetLength(0); b++)
//     {
//         sum += array[b, a];
//     }
//     Console.Write($"{ sum / array.GetLength(0)} ");
// }
// }
// Console.Write("Введите уоличество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите уоличество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray(myArray);
// Mean(myArray,m,n);