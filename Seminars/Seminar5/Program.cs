//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] myArray = new int [size];
//     for (int i=0; i<size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return myArray;
// }

// void ShowArray (int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for (int i=0; i<array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }
// void FindMinMAxSum (int[] array)
// {
// int sumPositive = 0;
// int sumNegative = 0;
// for(int i = 0; i < array.Length; i++)
// {
// if(array[i] > 0) sumPositive += array[i];
// else
// sumNegative += array[i];
// }
// Console.WriteLine($"Сумма положительных элементов {sumPositive}, а отрицательных {sumNegative}");
// }

// Console.WriteLine("Введите размер массива");
// int langht = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива");
// int max = Convert.ToInt32(Console.ReadLine());
// int[]newArray = CreateRandomArray(langht, min, max);
// ShowArray(newArray);
// FindMinMAxSum(newArray);

//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] myArray = new int [size];
//     for (int i=0; i<size; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return myArray;
// }

// void ShowArray (int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for (int i=0; i<array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }

// int[] ChangeElements (int[] array)
// {
//     for (int i=0; i<array.Length; i++)
//     {
//         array[i] = -array[i];
//     }
//     return array;
// }


// Console.WriteLine("Введите размер массива");
// int langht = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива");
// int max = Convert.ToInt32(Console.ReadLine());
// int[]newArray = CreateRandomArray(langht, min, max);
// ShowArray(newArray);
// newArray = ChangeElements(newArray);
// ShowArray(newArray);

//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

// int[] CreateRandomArray(int size)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} элемент массива");
//         myArray[i] = Convert.ToInt32(Console.ReadLine());
//         }
// return myArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив->");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// Console.WriteLine();
// }

// void Show(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     if (num ==array[i]) Console.WriteLine($" Число {num} входит в массив");
// }

// Console.WriteLine("Размер массива");
// int Length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите число");
// int numb = Convert.ToInt32(Console.ReadLine());
// int[] newarray=CreateRandomArray(Length);
// ShowArray(newarray);
// Show( newarray ,numb);

//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

// int[] CreateRandomArray(int size) //, int minValue, int MaxValue)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(0,1000);
//         }
//         return myArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Полученный массив->");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// Console.WriteLine();
// }

// void Sum(int[] array, int num, int num2)
// {
//     int count=0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]>=num && array[i]<=num2)
//         count =count+1;
//         }
// Console.WriteLine(count);
// }

// Console.WriteLine("Размер массива");
// int Length = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите нижнюю границу");
// int numb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(" Введите верхнюю границу");
// int numb2 = Convert.ToInt32(Console.ReadLine());
// int[] newarray=CreateRandomArray(Length);
// ShowArray(newarray);
// Sum( newarray ,numb, numb2);