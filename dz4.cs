// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵); 2, 4 -> 16
// Console.WriteLine("Введите числа: ");
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int i = 1, pr = 1;
// while (i <= b)
// {
//     pr *= a;
//     i++;  
// }
// Console.WriteLine($"{a} в степени {b} равно {pr}");

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12

// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine());
// int sum = 0;
// while (a != 0) 
// {
//     sum += a % 10;
//     a /= 10;
// }
// Console.WriteLine(sum);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]
int [] massiv = {1, 2, 5, 7, 19, 24, 31, 39};
for (int i=0; i < massiv.Length; i++)
{
    Console.Write($"{massiv[i]}, ");    
}
