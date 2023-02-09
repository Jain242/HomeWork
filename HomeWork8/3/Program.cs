// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




/*---FUNCTION---*/


int[,] MultiplicationMatrix (int [,] array1, int[,] array2){
 int[,] product = new int [array1.GetLength(1),array2.GetLength(0)];
  for (int i = 0; i < product.GetLength(0); i++)
        for (int j = 0; j < product.GetLength(1); j++)
            product[i,j] = 0;
    
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        for (int j = 0; j < array2.GetLength(0); j++)
    {
        for (int k = 0; k < array1.GetLength(1); k++)
        {
             product [i,j] += array1[i,k]*array2[k,j];
        
        }
    }       
    }
return product;
}


int[,] GenerateArray(int m, int n, int min, int max)

{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = random.Next(min, max + 1);

    return array;
}


void PrintArray2D(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) { 
        for ( int j = 0; j < array.GetLength(1); j++){
           
            Console.Write($" {array[i,j]}\t");
       
    }System.Console.WriteLine();
}
}




/*---MAIN---*/

Console.WriteLine(" Задача 58 ");
int [,] array1 = GenerateArray(2,2,0,10);
int [,] array2 = GenerateArray(2,2,0,10);
System.Console.WriteLine("1-я матрица");
PrintArray2D(array1);
System.Console.WriteLine("2-я матрица");
PrintArray2D(array2);
System.Console.WriteLine("Произведение матриц");
int [,] result = MultiplicationMatrix(array1,array2);
if (array1.GetLength(1) != array2.GetLongLength(0))
{System.Console.WriteLine($"Данные матрицы нельзя умножить!");}
else
PrintArray2D(result);

//int [,] result = MultiplicationMatrix(array1,array2);
//PrintArray2D(result);}