// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

void showArray(int[]nums)
{
    for(int i=0;i < nums.Length; i++)
    {
        Console.Write($"{nums[i]},");
    }
}

//int[] nums = new int[8]