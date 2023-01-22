//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).
///14212 -> нет
//12821 -> да
//23432 -> да
//1231

System.Console.WriteLine("Задача 19");

void Polindrom(int num){
  if (num/10000 == num%10) 
    if ((num/1000)%10 == (num%100)/10)
    System.Console.WriteLine("Да");
    else System.Console.WriteLine("Нет");
else System.Console.WriteLine("Нет");
   }


System.Console.Write("Ведите 5-ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>=10000 && number<100000)
Polindrom(number);
else 
{System.Console.WriteLine("Число не 5-ти значное!")};

int em;
em = 23;

