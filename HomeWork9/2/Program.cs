// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


/*---FUNCTION---*/
int PrintNumber (int m, int n){
int sum = 0;
if (m>n)
{sum  = m + PrintNumber(m-1,n);
}
else if (n>m){
 sum = n + PrintNumber(m,n-1);
}
else if (n == m){
    sum+=m;
}
return sum;
}


/*---MAIN---*/


Console.WriteLine("Задача 66 ");
Console.WriteLine();
Console.Write("Введите M: ");
int M = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Сумма эллементов в промежутке: {PrintNumber(M,N)}");
