// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumDigits(int n){
int digitCount = (int)Math.Log10(Math.Abs(n)) + 1;
int result = 0;
for (int i = 1; i <= digitCount; i++)
{result = Math.Abs(n % 10) + result;
 n = n/10;   
}
return result;

}



System.Console.WriteLine("Задача 27");
System.Console.Write("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
int result = SumDigits(a);
System.Console.WriteLine($"Ваш результат: {result}");
