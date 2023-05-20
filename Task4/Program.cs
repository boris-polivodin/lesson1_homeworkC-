// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
class Program {
    public static void Main (string[] args) {
        Console.Write("Input any number");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= number; i+=2)
        {
            Console.Write(i);
        }
     }
}
