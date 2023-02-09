// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




/*---FUNCTION---*/

//Создаём массив строк из координат 

string [] Visual3D (int m) {
int index = 0;

string [] Point = new string [m*m*m];

for (int z = 0; z < m; z++)
    for (int x = 0; x < m; x++)
{  
            for (int y = 0; y < m; y++)
    {
        Point[index] = $"({x},{y},{z})";
        index++;
    }
}
return Point;
}

//Создаём массив неповторяющихся эллементов от 10 до 99 размером N*N*N

int [] RandomElemArray(int n){
Random random = new Random();
    int [] randomAr = new int [n*n*n];
    randomAr[0] = random.Next(10,100);
    for (int i = 1; i < randomAr.Length; i++)
    {  randomAr[i] = random.Next(10,100);
        for (int j = 0; j < i; j++)
    {      while (randomAr[i] == randomAr[j])
                  randomAr[i] = random.Next(10,100);
    }  
    }
return randomAr;
}

//Генерируем 3-х мерную матрицу из случайных эллементов

int[,,] GenerateArray3D(int m)

{   
    int[,,] array = new int[m, m, m];
    int[] randomAr = RandomElemArray(m);
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k <  array.GetLength(2); k++,index++)
            {
                array[i,j,k] = randomAr[index];
                
            }
    return array;
}


//Выводим3-х мерную матрицу из случайных эллементов в строчку, добавляя коррдинаты элемента

void PrintArray3D(int[,,] array) {
int index = 0;
string [] Dot = Visual3D(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++) { 
        for ( int j = 0; j < array.GetLength(1); j++){
           for (int k = 0; k < array.GetLength(2); k++)
           {Console.Write($" {array[i,j,k]} {Dot[index]}");
           index++;
           }
            Console.WriteLine();
       
    }
}
}



/*---MAIN---*/

Console.WriteLine(" Задача 60 ");
Console.WriteLine();
Console.Write("Введите размерность массива: ");
int N = Convert.ToInt32(System.Console.ReadLine());
int[,,] result =  GenerateArray3D(N);
System.Console.WriteLine("Ваш трёхмерный массив в формате {Значение}(Точка в 3D пространстве)");
PrintArray3D(result);