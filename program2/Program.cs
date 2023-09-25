using System;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            int countOfNumbers = 3;
            double max = 0;


            for (int i=0;i<countOfNumbers;i++){
                Console.WriteLine($"Введите {i+1}-ое число");
                if (i==0){
                    max = Convert.ToDouble(Console.ReadLine());
                }
                else {
                    double checker = Convert.ToDouble(Console.ReadLine());
                    if (checker>max) {
                        max = checker;
                    }
                }
            }
            Console.WriteLine($"Максимальное число = {max}");


        }
    }
}
