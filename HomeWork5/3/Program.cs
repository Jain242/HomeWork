// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



 void PrintArray(double [] array){
 System.Console.Write("[");
int n = array.Length;
if (n == 0) System.Console.WriteLine("]");
 for (int i = 0; i < n; i++)
{if(i == n-1)
   System.Console.WriteLine($"{array[i]}]");
 else System.Console.Write($"{array[i]}, ");
 }
}


void EnterArray(double [] array, int n){
   Random rnd = new Random();
for (int i = 0; i < n; i++)
{
     //array[i] = rnd.Next(0,100)/20;
     array[i] = Math.Round(rnd.NextDouble()*100,2);
}
}



double MaxMin(double [] array){
    double max = array[0];
    double min = array[0];
for (int i = 1; i < array.Length; i++)
{if (array[i]>max) max = array[i];
 if (array[i]<min) min = array[i];
}
return max-min;


}

System.Console.WriteLine("Задача 38");
System.Console.Write("Введите колличество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0){System.Console.WriteLine("Ввели отрицательное число!!!");
return;}
double[] arr = new double [a];
EnterArray(arr,a);
PrintArray(arr);
System.Console.WriteLine($"Разница между максимальным и минамальным элементом: ");
System.Console.WriteLine("{0:0.00}",MaxMin(arr));