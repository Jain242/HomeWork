// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Stepen(int a, int b){
return (int) Math.Pow(a,b);
}





System.Console.WriteLine("Задача 25");
System.Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b<0){ System.Console.WriteLine("Вы ввели отрицательно число");
return;}
int result = Stepen(a,b);
System.Console.WriteLine($"Ваш результат: {result}");
