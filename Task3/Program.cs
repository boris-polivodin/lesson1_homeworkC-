﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
class Program {
    public static void Main (string[] args) {
        Console.Write("Input any number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
}