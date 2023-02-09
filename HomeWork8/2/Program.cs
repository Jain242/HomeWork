// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void SummString(int [,] array){
int[] TempArray = new int [array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++)
    {  
        for (int j = 0; j < array.GetLength(1); j++)
        TempArray[i] += array[i,j];
    }
int max = 0;
   for (int i = 1; i < TempArray.Length; i++)
        {if (TempArray[max]<TempArray[i]) max = i;}
System.Console.WriteLine($"{max+1}-я строка с наибольшей суммой");

}


/*---MAIN---*/

System.Console.WriteLine(" Задача 56 ");
Console.Write("Введите кол-во строк массива N: ");
int N = Convert.ToInt32(System.Console.ReadLine());
Console.Write("Введите кол-во столбцов массива M: ");
int M = Convert.ToInt32(System.Console.ReadLine());
int [,] array = GenerateArray(N,M,0,10);
System.Console.WriteLine("Ваш массив");
PrintArray2D(array);
SummString(array);
