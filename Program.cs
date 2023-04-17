// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();

while (num.Length != 5)
    {
        Console.WriteLine("Вы ввели не пятизначное число, попробуйте еще раз...");
        num = Console.ReadLine();
    }
    
if (num[0] != num[4]) Console.WriteLine("Число не является палиндромом");
    
else if (num[1] != num[3]) Console.WriteLine("Число не является палиндромом");

else Console.WriteLine("Число является палиндромом");
