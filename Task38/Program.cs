// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);  // для корректировки размера на индекс
        Console.Write($"{res[i]} ");
    }
    return res;
}

int ArMax(int[] ar)
{
    int max = ar[0];
    for (int index = 0; index < ar.Length; index++)
    {
        if (ar[index] > max) max = ar[index];
    }
    return max;
}

int ArMin(int[] arr)
{
    int min = arr[0];
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] < min) min = arr[index];
    }
    return min;
}

int[] array = GetArray(10, -100, 100);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {ArMax(array)-ArMin(array)}");
