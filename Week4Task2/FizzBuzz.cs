using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Task2
{
    class FizzBuzz
    {
        public string ResultGame(int input)
        {
            if(input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";

            }else if( input%3 == 0){

                return "Fizz";

            }else if ( input%5 == 0)
            {
                return "Buzz";
            }
            return input.ToString();
        }
    }
}
