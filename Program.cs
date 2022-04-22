// Задача 1: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int a = new Random().Next(99,1000);
int b = a%1000;
int c = b / 100;
int d = a%10;
//Console.WriteLine($"Число {a}");
//Console.WriteLine($"Если из числа {a} убрать вторую цифру, то получится число {c}{d}");


// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int q = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Дано число: {q}");

if (q / 100 > 0) Console.WriteLine($"Третьей цифрой числа {q} является цифра {q /100 % 10}");
else Console.WriteLine($"У числа {q} нет третьей цифры");

Console.WriteLine();


// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int dayNumber = int.Parse(Console.ReadLine());
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string Result = "";

if (dayNumber > 5) Result = $". Ура! Это выходной день!";
else Result = $", рабочий день.";

System.Console.WriteLine();
System.Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{Result}");
System.Console.WriteLine();

