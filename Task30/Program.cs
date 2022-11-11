// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0] 

Console.Clear();

int[] array = new int[8];

void newArray(int []collection)
{
    int index = 0;
    while (index <= 7)
    {
        collection[index] = new Random().Next(0,2);
        index++;
    }
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
printArray(array);
newArray(array);
printArray(array);
