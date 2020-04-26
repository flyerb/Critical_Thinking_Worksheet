using System;
using System.Collections.Generic;
using System.Text;

namespace Critical_Thinking_Worksheet
{
    class While_Loop
    { public void FirstQuestion()
        {
            int counter = 5;
            while(counter < 25)
            {
                counter++;
                //Counter will run 20 times. It's first going to check the counter and if it's less than 25, it'll run.
            }
            
        }

        public void UserInput()
        {
            Console.WriteLine("Please enter a number less than 25 for intiate the loop.");
            int counter = Convert.ToInt32(Console.ReadLine());
            while( counter < 25)
            {
                counter++;
                Console.WriteLine(counter);
            }
        }

        public void EqualTo42()
        {
            Console.WriteLine("Please enter the number 42.");
            int counter = Convert.ToInt32(Console.ReadLine());
            while( counter != 42)
            {
                Console.WriteLine("Your answer was not equal to 42.");
                break;
            }
        }
    }
}
