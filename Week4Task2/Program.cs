using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in our FizzBuzz Game!\n");
            Console.WriteLine("Type your number: \n");

            while (true)
            {              
                var yourNumber = GetInput();
                var fizzBuzz = new FizzBuzz();
  
                var result = fizzBuzz.ResultGame(yourNumber);
                Console.WriteLine(result);
                Console.WriteLine("Type your number, again or type 'q' to quit game");                  
            }
        }

        private static int GetInput()
        {
            while (true)
            {
                var value = Console.ReadLine();

                if(value.ToUpper() == "Q")
                {
                    Environment.Exit(0);
                }

                if(!int.TryParse(value, out int input))
                {       
                    Console.WriteLine("Wrong value. Type your number, please: \n");
                    continue;
                }
                return input;                
            }
        }
    }
}
