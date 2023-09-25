using System;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
           
            int number = 0;
            Console.WriteLine("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number; i++) {
                if (i%2==0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
