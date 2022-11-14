using System;
using static System.Console;

string[] M;
WriteLine("Введите символы через пробел");
string symbol = ReadLine();
M = symbol.Split(' ');
var result = new string[M .Length];
var realSize = 0;
    foreach (var value in M )
    {
        if (value.Length <= 3)
        {
            result[realSize] = value;
            realSize++;
        }
    }
WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
ReadKey(true);