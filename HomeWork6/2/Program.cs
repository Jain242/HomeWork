// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void printPoint(double b1,double k1,double b2,double k2){
double x = (b2-b1)/(k1-k2);
double y = (k1*x) + b1;
if (k1 == k2) {
System.Console.WriteLine($"Прямые не пересекаются");
}
else
System.Console.WriteLine($"Точка пересечения прямых ({x};{y})");
}


System.Console.WriteLine(" Задача 43 ");
System.Console.WriteLine("Введите b1 и k1:");
double b1 = Convert.ToInt32(System.Console.ReadLine());
double k1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите b2 и k2:");
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{b1} ,{k1} ,{b2} ,{k2}");
printPoint(b1,k1,b2,k2);