using System;
using static System.Console;

Clear();
int[] array = GetRand(3,500,1999);
Console.WriteLine($"[{String.Join(", ", array)}]");
int[] GetRand(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue);
    }
    return result;
}
