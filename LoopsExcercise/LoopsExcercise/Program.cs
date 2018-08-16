using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            One();
            //Two();
            //Three();
        }

        public static void One()
        {

            Console.Write("enter a number ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("enter an another number ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("-----for loop-----");

            for (int i = first; i <= end; i++)
            {
                Console.WriteLine($"{i}     {i * 10}     {i * 100}     {i * 10000}");
            }

            Console.WriteLine();

            Console.WriteLine("-----while loop-----");

            int n = first;
            while (n <= end)
            {
                Console.WriteLine($"{n}     {n * 10}     {n * 100}     {n * 10000}");
                n++;
            }

            Console.WriteLine();

            Console.WriteLine("-----do while loop-----");

            n = first;
            do
            {
                Console.WriteLine($"{n}     {n * 10}     {n * 100}     {n * 10000}");
                n++;
            } while (n <= end);

            Console.ReadKey();
        }

        public static void Two()
        {

            Console.Write("enter the number ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("-----for loop-----");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {input} = {i * input}");
            }

            Console.WriteLine();

            Console.WriteLine("-----while loop-----");

            int n = 1;
            while (n <= input)
            {
                Console.WriteLine($"{n} x {input} = {n * input}");
                n++;
            }

            Console.WriteLine();

            Console.WriteLine("-----do while loop-----");

            n = 1;
            do
            {
                Console.WriteLine($"{n} x {input} = {n * input}");
                n++;
            } while (n <= input);

            Console.ReadKey();
        }

        public static void Three()
        {
            Console.WriteLine("-----for loop-----");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i}     {i * i}     {i * i * i}");
            }

            Console.WriteLine();

            Console.WriteLine("-----while loop-----");

            int n = 0;
            while (n <= 10)
            {
                Console.WriteLine($"{n}     {n * n}     {n * n * n}");
                n++;
            }

            Console.WriteLine();

            Console.WriteLine("-----do while loop-----");

            n = 1;
            do
            {
                Console.WriteLine($"{n}     {n * n}     {n * n * n}");
                n++;
            } while (n <= 10);

            Console.ReadKey();
        }
    }
}
