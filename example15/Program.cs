﻿/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру");
int i = int.Parse (Console.ReadLine());
if (i==6||i==7) Console.WriteLine ("да");
 else 
 Console.WriteLine ("нет");
