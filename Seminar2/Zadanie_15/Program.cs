﻿/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Например:
6 -> да
7 -> да
1 -> нет */
Console.Write("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 1 && num <= 5) Console.Write("Нет");
else if(num == 6 || num == 7) Console.Write("Да");
else Console.Write("Такого дня недели не существует");