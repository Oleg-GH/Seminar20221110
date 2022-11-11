// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21 


Console.Clear();
int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    { 
        res[i] = new Random().Next(0, 12); 
        Console.Write($"{res[i]} "); 
    }
    return res;
}

void printArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;   
    }
    Console.WriteLine();
}

int[] arr = GetArray(5);
Console.WriteLine();
int size = arr.Length;
int[] resArr = new int[size/2+1];
for(int index = 0; index < size/2; index++)
{
    int result = arr[index] * arr[size - index -1];
    resArr[index] = result;
    Console.WriteLine($"{result}");
}
printArray(resArr);