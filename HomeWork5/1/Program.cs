//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//   которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



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
     array[i] = new Random().Next(100,1000);

}
}


int CheckedChet(int [] array){
    int count = 0;
for (int i = 0; i < array.Length; i++)
{if (array[i]%2 == 0)
count +=1;  
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
System.Console.WriteLine("Ваш массив");
PrintArray(arr);
System.Console.WriteLine($"Колличество чётных элементов в массиве: {CheckedChet(arr)}");

