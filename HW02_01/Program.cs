// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Prompt(string message)
{
    Console.Write(message);
    String value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Введите трехзначное число > ");
if(number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввкели не трехзгачное чило, пожалуйста повторите ввод: ");
    return;
}
Console.WriteLine($"Введенное число `{number}`");
int SecondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра `{SecondRank}");