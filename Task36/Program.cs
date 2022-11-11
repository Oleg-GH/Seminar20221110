// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.  [3, 7, 23, 12] -> 19        [-4, -6, 89, 6] -> 0

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

int[] array = GetArray(10, -100, 100);
Console.WriteLine();
int sum = 0;
for (int i = 1; i <= array.Length; i = i + 2)
{
    sum += array[i];
}

Console.WriteLine($"Сумма нечетных элементов в массиве равна {sum}");
