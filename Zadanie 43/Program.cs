// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Введите число K1: ");
var numbk1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число B1: ");
var numbb1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите число K2: ");
var numbk2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число B2: ");
var numbb2 = Convert.ToDouble(Console.ReadLine());

double numx = (numbb1-numbb2)/(numbk2 - numbk1);
   
double numy = numbk2*numx + numbb2;

System.Console.WriteLine($"({numx}, {numy})");
