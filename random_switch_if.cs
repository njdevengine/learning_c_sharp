using System;

namespace FirstConsoleProject
{
    class MainClass
    {
        public static void Main(string[] args) // this is a method called main. it is called when the program begins.
        {
            Start:
            Random numgen = new Random();

            int num1 = numgen.Next(1,11);
            int num2 = numgen.Next(1, 11);
            Console.WriteLine("What is " + num1 + " plus " + num2 + "?");
            int answer = Convert.ToInt32(Console.ReadLine());
            if(answer == num1 + num2)
            {
                Console.WriteLine("Correct!");
            } else
            {
                int responses = numgen.Next(1, 4);
                switch (responses)
                {
                    case 1:
                        Console.WriteLine("bad");
                        break;
                    case 2:
                        Console.WriteLine("wrong");
                        break;
                    default:
                        Console.WriteLine("keep trying");
                        break;
                }
            }

            Console.ReadKey();
            goto Start;
        }
    }
}
