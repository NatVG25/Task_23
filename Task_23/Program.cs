using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите исходное число для вычисления факториала:");
            int n = Convert.ToInt32(Console.ReadLine()); //ввод исходного числа с консоли
            FactorialAsync(n); //запуск асинхронного метода
            Console.ReadKey();
        }
        static void Factorial(int n) //метод вычисления факториала
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);
        }
        static async void FactorialAsync(int n) //асинхронный метод вычисления факториала
        {
            await Task.Run(() => Factorial(n)); //создание "горячей" задачи для выполнения метода Factorial
        }
    }
}
