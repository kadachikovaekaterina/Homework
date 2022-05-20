// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void FillArray(double[,] array)                                          
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().NextDouble();
//         }
//     }
// }
// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int m = 5;
// int n = 4;
// double[,] array = new double [m, n];

// FillArray(array);
// PrintArray(array);




// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// void FillArray(int[,] array)
// {
//     for (int m = 0; m < array.GetLength(0); m++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++)
//         {
//             array[m, n] = new Random().Next(1, 20);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int m = 0; m < array.GetLength(0); m++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++)
//         {
//             Console.Write($"{array[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int m = 5;
// int n = 5;
// int[,] array = new int[m, n];

// FillArray(array);
// PrintArray(array);

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// string Position(int[,] array)
// {
//     string result = string.Empty;
//     for (int m = 0; m < array.GetLength(0); m++)
//     {
//         for (int n = 0; n < array.GetLength(1); n++)
//         {
//             if (num == array[m, n]) result += $"({m}, {n})";
//         }
//     }
//     if (result == string.Empty) result = "Такого элемента нет";
//     return result;
// }
// Console.WriteLine(Position(array));


// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 20);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
string ArithmeticMean(int[,] array)
{
    string result = string.Empty;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        int sum = 0;
        int count = 0;
        double mean = 0;
        for (int m = 0; m < array.GetLength(0); m++)
        {
            sum += array[m, n];
            count++;
        }
        mean = sum / count;
        result += mean.ToString() + " ";
    }
    return result;
}
int m = 5;
int n = 5;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(ArithmeticMean(array));