// Задача 33: Задайте масив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да 

Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random(). Next(minValue, maxValue + 1);  // для корректировки размера на индекс
        Console.Write($"{res[i]} ");
    }
    return res;
    //Console.WriteLine();
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine();
Console.Write("Введите искомое число: ");
int num = int.Parse(Console.ReadLine() ?? "0");

bool count = false;

foreach (int el in array)
{
    if (el == num) count = true;
}
Console.WriteLine(count == true ? "Yes" : "No");


// void CheckArray(int[] array, int a)
// {
//     int x = 0;
//     foreach(int element in array)
//     {
//         if(element == a)
//         {
//             x = element;
//         }
//     if (x == 0) Console.WriteLine('Нет');    
//     else Console.WriteLine("Да");
// }



