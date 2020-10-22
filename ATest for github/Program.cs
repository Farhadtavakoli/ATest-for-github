using System;
using System.Text;

namespace ATest_for_github
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] color= {"Red,Green, Yellow, Blue,Cyan"};
            Console.Write("Ange ditt namn: ");
            string namn = Console.ReadLine();
            for(int i=0;i<namn.Length;i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10 - i, 10+i+i); // Printing backward
                Console.Write(namn[i]+"*");
            }
            Console.ReadKey();
        }
    }
}
