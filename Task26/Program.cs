// Задача 26: Напишите программу, которая принимает на вход число и
// выдаёт количество цифр в числе. 456 -> 3 78 -> 2 89126 -> 5

Console.Clear();
Console.WriteLine("Введите ваше число: ");
int number = int.Parse(Console.ReadLine());

int GetNum(int num)
{
    int count = 0;
    while(num>=1)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.WriteLine($"{GetNum(number)}");
