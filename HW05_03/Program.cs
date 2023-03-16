// Задайте массив вещественных числе и найти разницйу между максимальным и минимальным элементом массива

double[] doubleArray = new double[10];

for (int i = 0; i < doubleArray.Length; i++)
{
    doubleArray[i] = Math.Round((new Random().NextDouble() * 100), 3);

    Console.Write($"{doubleArray[i]} ");
}

double maxManual = doubleArray[0];
double minManual = doubleArray[0];

double maxAuto = doubleArray.Max();
double minAuto = doubleArray.Min();

for (int i = 0; i < doubleArray.Length; i++)
{
    if(doubleArray[i] > maxManual)
    {
        maxManual = doubleArray[i];
    }
    if(doubleArray[i] < minManual)
    {
        minManual = doubleArray[i];
    }
}

double result = maxManual-minManual;
Console.WriteLine($"Разница между max и min ={result}");