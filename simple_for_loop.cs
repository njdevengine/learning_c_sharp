using System;

namespace FirstConsoleProject
{
    class MainClass
    {
        public static void Main(string[] args) // this is a method called main. it is called when the program begins.
        {
            Start:
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            goto Start;
        }
    }
}
