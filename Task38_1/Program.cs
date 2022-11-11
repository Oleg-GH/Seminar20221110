// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetArray(int size, int limit)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble() * limit, 2);  // limit - для расширения диапазона случайных чисел
        Console.Write($"{res[i]} ");
    }
    return res;
}

double ArMax(double[] ar)                            // метод поиска максимального элемента массива
{
    double max = ar[0];
    for (int index = 0; index < ar.Length; index++)
    {
        if (ar[index] > max) max = ar[index];
    }
    return max;
}

double ArMin(double[] arr)                           // метод поиска минимального элемента массива
{
    double min = arr[0];
    for (int index = 0; index < arr.Length; index++)
    {
        if (arr[index] < min) min = arr[index];
    }
    return min;
}

Console.Write("Введите размер массива:  ");
int size = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите диапазон элементов массива, например, 10, или 100, или 1000: ");
int limit = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
double[] array = GetArray(size, limit);
Console.WriteLine();
double max = ArMax(array);
double min = ArMin(array); 
Console.WriteLine($"Разница между максимальным /{max}/ и минимальным /{min}/ элементами массива равна {Math.Round(max-min, 2)}");
