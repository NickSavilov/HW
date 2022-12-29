//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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

//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

// int[,]Create2DRandomArray(int rows, int columns)
// {
//     int[,] newarray = new int [rows,columns];
//     for (int i=0; i<rows; i++)
//     {
//         for (int j = 0; j<columns; j++)
//         {
//             newarray [i,j] = i+j;
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

// Console.Write("Введите уоличество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите уоличество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(m,n);
// Show2DArray(myArray);

//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81 ** 2 **9**
//8 4 2 4

// int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//     {
// newArray[i,j] = new Random().Next(minValue, maxValue+1);
// }
// }
// return newArray;
// }

// int[,] ArrayEvenSqare(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i=i+2)
//     {
//         for (int j = 0; j < array.GetLength(1); j=j+2)
//     {
//         array[i, j] = array[i, j] * array[i, j];
//         }
//     }
// return array;
// }

// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
// Console.WriteLine();
//     }
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
// Console.WriteLine();
// Show2DArray (ArrayEvenSqare(myArray));

//Задача 4. адайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//Например, задан массив:

//1 4 7 2 Главная диагональ это когда i и j совпадают
//5 9 2 3
//8 4 2 4

//Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows,columns];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//     {
// newArray[i,j] = new Random().Next(minValue, maxValue+1);
// }
// }
// return newArray;
// }
// void SumdDiagonal(int[,] newArray)
// {
//     int sum = 0;
//     for(int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < newArray.GetLength(1); j++)
//     {
//         if(i == j)
//         sum = sum + newArray[i,j];
//     }
// }
// Console.WriteLine(sum);
// }
// void Show2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//     Console.WriteLine();
//     }
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
// SumdDiagonal(myArray);
