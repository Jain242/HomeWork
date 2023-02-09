// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


/*---FUNCTION---*/

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

void Sort(int [,] array){
int temp = 0;
for (int i = 0; i < array.GetLength(0); i++)
    {  
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {if (array[i,k]>array[i,j]){
             temp = array[i,j];
             array[i,j] = array[i,k];
             array[i,k] = temp;

            }
            }
        }
    }
}


/*---MAIN---*/

System.Console.WriteLine(" Задача 54 ");

Console.Write("Введите кол-во строк массива N: ");
int N = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите кол-во столбцов массива M: ");
int M = Convert.ToInt32(System.Console.ReadLine());
int [,] array = GenerateArray(N,M,0,10);
System.Console.WriteLine("Ваш массив");
PrintArray2D(array);
Sort(array);
System.Console.WriteLine("Отсортированный массив");
PrintArray2D(array);

