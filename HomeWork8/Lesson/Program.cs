//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника



// --- FUNCs --- //


int[,] GenerateInt2DArray(int n) {

  
    Random random = new Random();
    int[,] array = new int[n, n];
    array [0,0] = 1;
    for (int i = 1; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
         if (j==1 || j==array.GetLength(0) -1)
         array[i,j] = 1;  
         else
         array[i,j] = array[i-1,j]+array[i-1,j+1];  
        }
    }

    return array;
}

void Print2DArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        List<int> currentRow = new List<int>();
        for (int j = 0; j < array.GetLength(1); j++) {
            currentRow.Add(array[i,j]);
        }
        Console.WriteLine(string.Join("  ", currentRow));
    }
}

System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());


int [,] array = GenerateInt2DArray(n);
Print2DArray(array);
