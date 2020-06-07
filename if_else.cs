using System;

namespace hello_world
{
    class MainClass
    {
        public static void Main(string[] args) // this is a method called main. it is called when the program begins.
        {
        Start:
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18) {
                Console.WriteLine("You must wait " + (18-age) + " years to enter.");
            } else if (age == 18) {
                Console.WriteLine("You are the correct age to enter.");
            } else{
                Console.WriteLine("You may enter.");
            }
            Console.ReadKey();
            goto Start;
        }
    }
