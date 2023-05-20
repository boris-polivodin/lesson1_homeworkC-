//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Input first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second namber");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
{
    max = number2;
}
Console.WriteLine("max = {0}", max);