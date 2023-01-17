//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите 2 числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int resault = Math.Max(a,b);
Console.WriteLine("Максимальное число: " + resault);

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

System.Console.WriteLine("Введите 3 числа:");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max1 = Math.Max(a,b);
int max2 = Math.Max(b,c);
Console.WriteLine("Максимальное число из 3-x: " );
if (max1>max2) {System.Console.Write(max1);}
else System.Console.WriteLine(max2);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет


System.Console.WriteLine("Введите число:");
a = Convert.ToInt32(Console.ReadLine());
if (a%2 == 0) {System.Console.WriteLine("Число чётное");}
else System.Console.WriteLine("Число нечётное");


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число:");
a = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= a)
 {
if ((count==a-1) || (count==a)) System.Console.Write(count);
else 
System.Console.Write(count+", " );
count+=2;
 }