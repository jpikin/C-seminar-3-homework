// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// string num = Console.ReadLine();

// while (num.Length != 5)
//     {
//         Console.WriteLine("Вы ввели не пятизначное число, попробуйте еще раз...");
//         num = Console.ReadLine();
//     }

// if (num[0] != num[4]) Console.WriteLine("Число не является палиндромом");
    
// else if (num[1] != num[3]) Console.WriteLine("Число не является палиндромом");

// else Console.WriteLine("Число является палиндромом");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите первую координату первой точки");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату первой точки");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату первой точки");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координату второй точки");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату второй точки");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату второй точки");
int Z2 = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow((X2-X1), 2) + Math.Pow((Y2-Y1), 2) + Math.Pow((Z2-Z1), 2));
Console.WriteLine(distance);