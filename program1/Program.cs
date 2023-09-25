using System;

namespace _4programs
{
    class Program
    {
        static void Main(string[] args)
        {
            
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

double firstNumber = 0;
double secondNumber = 0;
Console.WriteLine("Введите первое число: ");
firstNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
secondNumber = Convert.ToDouble(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine("Первое число больше второго.");
}
else if (secondNumber > firstNumber)
{
    Console.WriteLine("Второе число больше первого.");
}
else {
    Console.WriteLine("Числа равны.");
}
            
        }
    }
}
