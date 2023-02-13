// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



/*---FUNCTION---*/
void PrintNumber (int n){
if (n <=0)
return ;
else
if (n == 1)
{System.Console.WriteLine($"{n}");
}
else
System.Console.Write($"{n}, ");
PrintNumber(n-1);


}


/*---MAIN---*/


Console.WriteLine("Задача 64 ");
Console.WriteLine();
Console.Write("Введите N: ");
int N = Convert.ToInt32(System.Console.ReadLine());
PrintNumber(N);
