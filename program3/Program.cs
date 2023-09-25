using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

            Console.WriteLine("Введите число для проверки его на чётность:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number%2==0){
                Console.WriteLine("Число чётное.");
            }
            else {
                Console.WriteLine("Число нечётное.");
            }
        }
    }
}
