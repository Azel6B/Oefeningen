using System;

namespace _4_Loops_Pop_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            forloop();
            Console.WriteLine("");
            whileloop();
            Console.WriteLine("");
            foreachloop();
            Console.WriteLine("");
            dowhileloop();
        }




        public static void forloop()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " Keer ge for loept");
            }
        }
        public static void whileloop()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i + " Keer ge while loept");
                i++;
            }
        }

        public static void foreachloop()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number + " is een nummer in de lijst");
            }
        }
        public static void dowhileloop()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i + " Keer ge do while loept");
                i++;
            } while (i <= 10);
        }
    }
}