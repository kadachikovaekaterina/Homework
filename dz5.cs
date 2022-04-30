// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в
// массиве. [345, 897, 568, 234] -> 2
Console.Clear();
// void FillAray(int[]array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i]= new Random().Next(99,1000);
//     }
// }
// void Print(int[]array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length-1; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write($"{ array[length - 1]}.");
//     Console.WriteLine();
// }
// int [] mass = new int [4];
// FillAray(mass);
// Print(mass);
// int count = 0;
// for (int i=0; i < mass.Length; i++)
// {
//     if (mass[i]%2 == 0) count += 1;
// } 
// Console.WriteLine($"Количество четных чисел равно {count}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

// void FillAray(int[]array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i]= new Random().Next(-10,100);
//     }
// }
// void Print(int[]array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length-1; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write($"{ array[length - 1]}.");
//     Console.WriteLine();
// }
// int [] mass = new int [10];
// FillAray(mass);
// Print(mass);
// int sum = 0;
// for (int i = 0; i < mass.Length; i++)
// {
//     if (i%2 != 0) 
//     {
//         sum = sum + mass[i];
//     }
// }
// Console.WriteLine($"Сумма нечетных чисел равна {sum}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 20 };
int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным элементом равна - {max - min}");
