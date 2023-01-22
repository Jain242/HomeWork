//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Задача 21");


void EnterPoint(int [] array){
for (int i = 0; i < 3; i++)
 array[i]= Convert.ToInt32(Console.ReadLine());
}

void PrintPoint(int [] array){
System.Console.Write("(");
for (int i = 0; i < 3; i++)
{if(i == 2)
    System.Console.WriteLine($"{array[i]})");
else System.Console.Write($"{array[i]}, ");
}
}

double FindLine(int[] Point1,int[] Point2){
   double result = Math.Sqrt( Math.Pow(Point2[0]-Point1[0],2) + Math.Pow(Point2[1]-Point1[1],2) + Math.Pow(Point2[2]-Point1[2],2));
   return result;
}


System.Console.WriteLine("Введите кординаты точки A: ");
int [] A= {0, 0, 0};
EnterPoint(A);
PrintPoint(A);

System.Console.WriteLine("Введите кординаты точки B: ");
int [] B = {0, 0, 0};
EnterPoint(B);
PrintPoint(B);
double result = FindLine(A,B);
System.Console.Write("Расстояние между точками: ");
Console.Write("{0:0.00}", result);