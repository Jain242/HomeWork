//  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
 

 double[,] GenerateArray(int m, int n, int min, int max)

{
    double[,] array = new double[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = Math.Round(random.NextDouble()*random.Next(min, max + 1),1);


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


System.Console.WriteLine(" Задача 47 ");
System.Console.WriteLine("Задайте размерность массива");
System.Console.Write("Введите M:");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите N:");
int n = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Ваш массив:");
double [,] array = GenerateArray(m,n,1,10);
PrintArray2D(array);
