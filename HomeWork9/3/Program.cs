// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


/*---FUNCTION---*/
int FuncAccerman (int m, int n){
if (m == 0) 
  return n+1;
else if (m>0 && n == 0) 
  return FuncAccerman (m-1,1);
else if (n>0 && n>0)
 return FuncAccerman (m-1,FuncAccerman(m, n-1));
return 
FuncAccerman(m,n);
} 


/*---MAIN---*/


Console.WriteLine("Задача 68 ");
Console.WriteLine();
Console.Write("Введите параметр M: ");
int M = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите параметр N: ");
int N = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Функция Аккермана (M,N) = {FuncAccerman(M,N)}");
