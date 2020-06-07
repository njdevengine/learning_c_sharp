using System;

namespace hello_world
{
    class MainClass
    {
        public static void Main(string[] args) // this is a method called main. it is called when the program begins.
        {
            Start:
            int num01;
            int num02;

            Console.Write("We will take 2 numbers and multiply. First number: ");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your Second number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number is: " + num01 * num02);
            Console.ReadKey();
            goto Start;
        }
    }
}
