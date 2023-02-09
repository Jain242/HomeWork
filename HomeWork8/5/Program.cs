// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



/*---FUNCTION---*/
//Выводит массив без внешнего контура
void PrintArray2D(int[,] array) {
    for (int i = 1; i < array.GetLength(0)-1; i++) { 
        for ( int j = 1; j < array.GetLength(1)-1; j++){
           
            Console.Write($" {array[i,j]}\t");
       
    }System.Console.WriteLine();
}
}
//Заполняем массив внутри "0", по контруру "1"
int[,] GenerateArray(int m)

{
    int[,] array = new int[m, m];
      for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        if (i == 0|| j == 0 || i == array.GetLength(0)-1 || j == array.GetLength(0) -1 )
         array[i,j] = 1 ;
       else array[i,j] = 0 ;
    return array;

}


void PrintNumber(int [,] array, int i, int j,int s){

            while (array[i,j + 1] == 0) {
                array[i,j] = s;
                s++;
                j++;
            }

 
            while (array[i + 1,j] == 0) {
                array[i,j] = s;
                s++;
                i++;
            }

            while (array[i,j - 1] == 0) {
                array[i,j] = s;
                s++;
                j--;
            }


            while (array[i ,j] == 0) {
                array[i,j] = s;
                s++;
                i--;
            }
if (i <=(array.GetLength(0)-2)/2) {
 PrintNumber(array,i+1,j+1,s);}
}
// while (index <=array.GetLength(0)*array.GetLength(0))
// if (x == 1 && y == 0 && index%4){
// {array[0,i+=x] = index;
// if ( i == array.GetLength(0))


/*---MAIN---*/


Console.WriteLine(" Задача 62 ");
Console.WriteLine();
Console.Write("Введите размерность массива от 0 до N: ");
int N = Convert.ToInt32(System.Console.ReadLine()) + 2;
Console.Write("Введите число от 0 до N, с которого начинать заполнение : ");
int m = Convert.ToInt32(System.Console.ReadLine());
int[,] result =  GenerateArray(N);
System.Console.WriteLine("Первоначальный Массив");
PrintArray2D(result);
if(result.GetLength(0) == 3)
result[1,1] = 1;
else
PrintNumber(result,1,1,m);
System.Console.WriteLine("Массив заполненный по спирали:");
PrintArray2D(result);