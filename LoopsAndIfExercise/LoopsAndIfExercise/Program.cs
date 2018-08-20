using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndIfExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            Three();
        }

        public static void One()
        {

            int start = 76;
            int finish = 46;

            for(int i = start; i >= finish; i--)
            {
                if (i % 2 == 1) Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public static void Two()
        {
            Console.Write("give me a symbol ");
            string symbol = Console.ReadLine();
            Console.Write("give me a number ");
            int repeat = int.Parse(Console.ReadLine());

            for(int i = 0; i < repeat; i++)
            {
                Console.Write(symbol);
            }

            Console.ReadKey();
        }

        public static void Three()
        {
            string symbol = "@";
            int width = 3;
            int height = 4;

            for (int i = 0; i < height; i++)
            {
                for(int ii = 0; ii< width; ii++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
