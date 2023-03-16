// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int GetSumPositiveElements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        
        if(array[i] > 0 )
        {
            sum += array[i];
        }
    return sum;
}

int GetSumNegativeElements(int[ array])
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        
        if(array[i] < 0 )
        {
            sum += array[i];
        }
    return sum;
}
void PrintArrayToConsole(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        PrintArrayToConsole.Write(array[i] + "   ");
    }
    PrintArrayToConsole.WriteLine();
}

//---------------------------------------
