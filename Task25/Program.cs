﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

  Console.Write("Введите число A: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int B = Convert.ToInt32(Console.ReadLine());

int Degree(int A, int B)
{
  int result = 1;
  for(int i=1; i <= B; i++) result *= A; 
  return result;
}
 
  int degree = Degree(A, B);
  Console.WriteLine("Ответ: " + degree);