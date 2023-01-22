//System.Console.WriteLine("Введите число А");
//int a = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("Введите число Б");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a == 0 || b == 0)
//{System.Console.WriteLine("Ввели ноль");
//return;}
//if (a * a == b || b * b == a)
// if (a > b )  System.Console.WriteLine("А является Квадратом Б");
// else System.Console.WriteLine("Б является Квадратом A");
// else 
//System.Console.WriteLine("1-е число не является квадратом другого");
 
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

System.Console.WriteLine("Задача 10");
System.Console.Write("Введите трёхзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
int result;
if (Math.Abs(a)>=100 && Math.Abs(a)<=1000){
result = (Math.Abs(a)/10)%10;
System.Console.WriteLine("Вторая цифра:" + result);}
else {System.Console.WriteLine("Число не трёхзначное!");}


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.WriteLine("Задача 13");

System.Console.Write("Введите число:");
a = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(a) >=100 && Math.Abs(a)<=1000){
result = (Math.Abs(a)%10);
System.Console.WriteLine("Наше число: " + result);}
else 
if(Math.Abs(a)<100) System.Console.WriteLine("Нет третьего числа");
else {
int digitCount = (int)Math.Log10(Math.Abs(a)) + 1;
result = (int) Math.Pow(10,digitCount-3);
result = (Math.Abs(a)/result)%10;
System.Console.WriteLine("Наше число: " + result);
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


System.Console.WriteLine("Задача 15");

System.Console.Write("Введите число:");
a = Convert.ToInt32(Console.ReadLine());
if(a>=1 && a<=7)
System.Console.WriteLine(a<=5 ? "Нет" : "Да");
else  System.Console.WriteLine("Нет такого дня недели");