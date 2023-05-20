//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second namber: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third namber: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max) { max = number2; }
if (number3 > max) { max = number3; }
Console.WriteLine("max = {0}", max);
