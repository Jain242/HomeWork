

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


void ReadInt (string str,int [] array) {
int index = 0;
int j = 0;
string strTemp = "";
while (str.Length != 0){
index = str.IndexOf(" ");
if (index == -1) {
array[j]  = Convert.ToInt32(str);
break;}
strTemp = str.Substring(0, index);
str = str.Remove(0, index+1);
array[j]  = Convert.ToInt32(strTemp);
j++;
}
}

// Console.WriteLine("Введите массив целых чисел через пробел:");
// string input = Console.ReadLine()!;
// string[] numberStrings = input.Split(" ");
// int[] numbers = new int[numberStrings.Length];

// for (int i = 0; i < numbers.Length; i++)
//     numbers[i] = int.Parse(numberStrings[i]);

// PrintArray(numbers);

void PrintArray(int [] array){

    System.Console.Write($"{String.Join(", ", array)}\n");
}

int CheckPositive (int [] array){
int result = 0;
for (int i = 0; i < array.Length; i++)
{if (array[i] > 0) result +=1;}
return result;
}



System.Console.WriteLine(" Задача 41 ");
System.Console.WriteLine("Веедите колличество чисел: ");
int n =  Convert.ToInt32(Console.ReadLine());
if (n<0) {System.Console.WriteLine("Число отрцательное:");
return;}
int [] array = new int[n];
System.Console.WriteLine("Веедите числа через пробел и нажмите Enter: ");
string str1 =  System.Console.ReadLine();
ReadInt(str1, array);
PrintArray(array);
System.Console.Write("Колличество чисел, которые больше нуля: ");
System.Console.Write(CheckPositive(array));


