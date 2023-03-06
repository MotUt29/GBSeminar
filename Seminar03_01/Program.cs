// Напишите программу, которая принимает на вход число (А) и выдает сумму чиселот 1 до А
//Получие суммы чисел в диапазоне
int GetSumRange(int startNumber, int endNumber);
{
    int sum = 0;
    for (int i = startNumber; i <= endnumber; i++)
    {
        sum = sum +1;
    }

    return sum;
}

// Запрос исходного числа от пользователя
Console.Write("Ввдите число А: ");
int a = int.Parse(Console.ReadLine());

int sum = GetSumRange(1,a);
Console.WriteLine(sum);