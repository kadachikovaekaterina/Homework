// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. (A (3,6,8); B (2,1,-7))
int x1 = 3, y1 = 6, z1 = 8;
int x2 = 2, y2 = 1, z2 = -7;
double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine(length);
