// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 6; N = 2. -> "6, 5, 4, 3, 2"
Console.Clear();
// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

// void Numbers(int m, int n)
// {
//     if (m < n) return;
//     Console.Write(m + " ");
//     Numbers(m - 1, n);
// }
// Numbers(M,N);
// Console.ReadLine();



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

// int Sum(int a, int b)
// {
//     if (b == a) return b;
//     return a + Sum(a + 1, b);
// }
// Console.WriteLine(Sum(M,N));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int Ack( int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 & n == 0)
    {
        return Ack(m - 1, 1);
    }
    else 
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
}
Console.WriteLine(Ack(M, N));