﻿using Tyuiu.SvaykinVE.Sprint0.Task4.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DataService.Addition(1, 5));
        Console.WriteLine(DataService.Subtraction(1, 5));
        Console.WriteLine(DataService.Multiplication(1, 5));
        Console.WriteLine(DataService.Division(1, 5));
        Console.ReadKey();
    }
}