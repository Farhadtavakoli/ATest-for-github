using System;

namespace ATest_for_github
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ditt namn: ");
            string namn = Console.ReadLine();
            for(int i=0;i<namn.Length;i++)
            {
                Console.SetCursorPosition(10 - i, 10+i);
                Console.Write(namn[i]);

            }
            Console.ReadKey();
        }
    }
}
