//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void PrintCube(int number){
System.Console.Write(" --> ");
for (int i = 1; i <= number; i++)
{if (i == number ) System.Console.Write(Math.Pow(i,3));
else System.Console.Write($"{Math.Pow(i,3)}, ");
}
}



System.Console.WriteLine("Задача 23");
System.Console.Write("Введите число от 1 до N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N<1) 
{System.Console.WriteLine("Ввели число меньше 1 !!!");
return;}
PrintCube(N);
