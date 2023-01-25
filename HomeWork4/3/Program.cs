// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


void EnterArray(int [] array, int n){
for (int i = 0; i < n; i++)
{
    array[i]= Convert.ToInt32(Console.ReadLine());
}
}

 void PrintArray(int [] array){
 System.Console.Write("[");
int n = array.Length;
 for (int i = 0; i < n; i++)
{if(i == n-1)
   System.Console.WriteLine($"{array[i]}]");
 else System.Console.Write($"{array[i]}, ");
 }
}




System.Console.WriteLine("Задача 29");
System.Console.Write("Введите колличество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0){System.Console.WriteLine("Ввели отрицательное число!!!");
return;}
int[] arr = new int [a];
System.Console.WriteLine("Введите элементы массива");
EnterArray(arr,a);
System.Console.WriteLine($"Вашмассив");
PrintArray(arr);
