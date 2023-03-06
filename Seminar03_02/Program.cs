// Напишите программу, которая принимает на вход число и выдает колличество цифр в числе.
//Возвращает количество цифр в числе
int GetCountNum(int num)
{
    int count = 0;
    int sourseNum = num;
    while(sourseNum > 0)
    {
        sourseNum = sourseNum / 10;
        count++;
    }

    return count;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int countNum = GetCountNum(num);

Console.WriteLine(countNum);