// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void FillArrayRandomNumbers(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] array)

// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void EvenNumbers (int[] numbers)
// {
//     int count = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] % 2 == 0)
//         count++;
//     }
// Console.WriteLine($"количество чётных чисел в массиве -> {count} ");
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// EvenNumbers(numbers);

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)

// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }
// void Sum (int[] numbers)
// {
//     int sum = 0;
//     {
//         for (int z = 0; z < numbers.Length; z+=2)
//         sum = sum + numbers[z];
//     }
// Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");
// }

// Console.WriteLine("Введите размер массива  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// Sum(numbers);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 555);
//     }
// }
// void PrintArray(int[] array)

// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void FindMinMAxSum (int[] numbers)
// {
//     int max = numbers[0];
//     int min = numbers[0];
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] > max)
//         {
//             max = numbers[i];
//         }
//         else if (numbers[i] < min)
//         {
//             min = numbers[i];
//         }

//     }
// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Максимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");
// }
// int size = 10;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// FindMinMAxSum(numbers);