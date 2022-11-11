// Задача 28: Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N. 4 -> 24 5 -> 120 

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int GetNum(int number)
{
    int result = 1;
    while(number > 1)
    {
        result = result * number;
        number--;
    }
    return result;
}

Console.WriteLine(GetNum(number));
