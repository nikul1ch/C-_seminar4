﻿Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = A;
for (int i = 1; i < B; i++) C = C * A;
Console.Write($"Число {A} в степени {B} = {C}");

