﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123 [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0 [10, 11, 12, 13, 14] -> 5


Console.Clear();
int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    { 
        res[i] = new Random().Next(0, 1000); 
        Console.Write($"{res[i]} "); 
    }
    return res;
}
int[] arr = GetArray(23);
int count = 0;
int[] ResArray = new int[20];
foreach(int el in arr)
{
    if (el >=10 && el <= 99)
    {
        ResArray[count] = el;
        count++;        
    }    
}
Console.WriteLine();
Console.WriteLine(count);

