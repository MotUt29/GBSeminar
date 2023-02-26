// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите любое число: ");
int numb = Convert.ToInt32(Console.ReadLine());

int remDiv = numb % 2;

if(remDiv == 0)
{
    Console.WriteLine("Чётное число");
}
else
{
    Console.WriteLine("Не чётное число");
}
