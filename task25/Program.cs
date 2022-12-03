//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число А");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа В");
int b = Int32.Parse(Console.ReadLine());
int c = 1; 
for (int i = 0; i<b; i++)
{
    c*=a; 
  }
Console.Write(c);
Console.Write($" либо в степени ({a}){b}");
