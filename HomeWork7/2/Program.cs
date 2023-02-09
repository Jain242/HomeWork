// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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

void CheckPosition(int[,] array,int a,int b) {
 if (a < array.GetLength(0) && b < array.GetLength(1) && a>=0 && b>=0)
  System.Console.WriteLine($"Ваш эллемент: {array[a,b]}");
 else
 System.Console.WriteLine($"Эллемента с такой позицей нет");
}


System.Console.WriteLine(" Задача 50 ");
System.Console.WriteLine("Задайте размерность массива");
System.Console.Write("Введите M:");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите N:");
int n = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Ваш массив:");
int [,] array = GenerateArray(m,n,1,10);
PrintArray2D(array);
System.Console.Write("Введите позицию A: ");
int a = Convert.ToInt32(System.Console.ReadLine()) -1;
System.Console.Write("Введите позицию B: ");
int b = Convert.ToInt32(System.Console.ReadLine()) -1;
CheckPosition(array,a,b);