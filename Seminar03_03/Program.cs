// Напишите программу, которая принимает на вход число (N) и выдает произведение чисел от 1 до N

// Возвращение произвведнеия чисел от 1 до N
int GetMultipliction(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result *= 1;
    }
    return result;
}

Console.Write("Ввудеите число: ");
int num = int.Parse(Console.ReadLine);

int countNum = GetMultipliction(num);
Console.WriteLine(countNum);