//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Console.WriteLine("Введите пятизначное число");
// int N = int.Parse(Console.ReadLine());

// void Palindrom(int num)
// {
//     int del1 = num / 10000;
//     int ost1 = num % 10;

//     if(del1 == ost1)
//     {
//         num = num / 10;
//         int del2 = (num / 100) % 10;
//         int ost2 = num % 10;
//         if(del2 == ost2)
//             Console.WriteLine("Да");
//     }
//     else 
//     Console.WriteLine("Нет");
// }
 
// Console.WriteLine("Введите пятизначное число:");
// int number = int.Parse(Console.ReadLine()!);
// Palindrom(number);

//----------------------------------------------------------------------------------------------------------------------
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double xa = 7;
// double xb = 1;
// double ya = -5;
// double yb = -1;
// double za = 0;
// double zb = -9;

// double koren = Math.Sqrt(Math.Pow(xb - xa, 2)+Math.Pow(yb - ya, 2)+Math.Pow(zb - za, 2));

// Console.WriteLine(koren);

//----------------------------------------------------------------------------------------------------------------------
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Console.WriteLine("Vvedi N");
// double N = int.Parse(Console.ReadLine());
// double res = 1;

// while (res <= N)
// {
//     Console.WriteLine(Math.Pow(res, 3));
//     ++res;
// }