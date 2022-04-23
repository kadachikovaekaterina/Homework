// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.(14212 -> нет, 12821 -> да)
int num, i, j = 0, newnum;
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
newnum = num;
while (Convert.ToBoolean(num))
    {
        i = num % 10; 
        num = num / 10; 
        j = j * 10 + i; 
    }
Console.WriteLine("Обратное число: {0}", j);
if (newnum == j) 
    {
        Console.WriteLine($"Число {newnum} является палиндромом");
    }
else
    {
        Console.WriteLine("Число не является полиндромом");
    }


