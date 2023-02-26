// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введит первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введит второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введит третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(max < num1)
{
    max = num1;
}

if(max < num2)
{
     max = num2;
}

if(max < num3)
{    
    max = num3;
}
Console.WriteLine("max = " + max);
