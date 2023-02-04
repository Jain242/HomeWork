// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(double [] array){
 System.Console.Write("(");
int n = array.Length;
if (n == 0) System.Console.WriteLine("]");
 for (int i = 0; i < n; i++)
{if(i == n-1)
   System.Console.WriteLine($"{array[i]})");
 else System.Console.Write($"{array[i]}; ");
 }
}


 double[,] GenerateArray(int m, int n, int min, int max)

{
    double[,] array = new double[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = Math.Round(random.NextDouble()*random.Next(min, max + 1),0);

    return array;
}
void PrintArray2D(double[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) { Console.Write("[");
        for ( int j = 0; j < array.GetLength(1); j++){
           
            Console.Write($" {array[i,j]} ");
       
    }
     Console.WriteLine(']');
}
}

double [] average(double[,] array) {
  double result = 0;
  double [] arrayAver = new double[array.GetLength(1)];
  for (int i = 0; i < array.GetLength(1); i++)
  {for (int j = 0; j < array.GetLength(0); j++)
  { result += array[j,i];
  }
  arrayAver[i] = Math.Round(result / array.GetLength(0),1) ;
  result = 0;
  }
  return arrayAver;
}


System.Console.WriteLine(" Задача 47 ");
System.Console.WriteLine("Задайте размерность массива");
System.Console.Write("Введите M:");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите N:");
int n = Convert.ToInt32(System.Console.ReadLine());
double [,] array = GenerateArray(m,n,1,10);
System.Console.WriteLine(array.GetLength(0));
System.Console.WriteLine("Ваш массив:");
PrintArray2D(array);
double [] aver = average(array);
System.Console.WriteLine("Среднее арефмитическое стобцов");
PrintArray(aver);