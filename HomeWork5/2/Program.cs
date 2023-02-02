// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



 void PrintArray(int [] array){
 System.Console.Write("[");
int n = array.Length;
if (n == 0) System.Console.WriteLine("]");
 for (int i = 0; i < n; i++)
{if(i == n-1)
   System.Console.WriteLine($"{array[i]}]");
 else System.Console.Write($"{array[i]}, ");
 }
}


void EnterArray(int [] array, int n){
   
for (int i = 0; i < n; i++)
{
     array[i] = new Random().Next(-100,101);

}
}


int SumChet(int [] array){
    int count = 0;
for (int i = 0; i < array.Length; i++)
{if (i%2 == 1)
count +=array[i];  
}
return count;
}

System.Console.WriteLine("Задача 34");
System.Console.Write("Введите колличество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0){System.Console.WriteLine("Ввели отрицательное число!!!");
return;}
int[] arr = new int [a];
EnterArray(arr,a);
PrintArray(arr);
System.Console.WriteLine($"Сумма чисел на чётной позиции: {SumChet(arr)}");