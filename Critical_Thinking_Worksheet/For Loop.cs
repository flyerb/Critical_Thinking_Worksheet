using System;
using System.Collections.Generic;
using System.Text;

namespace Critical_Thinking_Worksheet
{
    class For_Loop
    {
        public void ForLoops()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"The loop is on {i} .");
                
            }
        }

        public void BackwardsLoop()
        {
            for (int i = 9; i < 10 && i > 4; i--)
            {
                Console.WriteLine($"This loop is counting down. We are now on {i}");
            }
        }

        public void UserChoice()
        {
            int userchoice = 10;
            for(int i = 0; i < userchoice; i++)
            {
                Console.WriteLine("You are participating in a for loop! Please type a number to continue.");
                userchoice = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void StringOfLetters()
        {
            string example = "Hello World";

            for(int i = 0; i < example.Length; i++)
            {
                Console.WriteLine(example[i]);
            }
        }

        public void EveryOtherLetter()
        {
            string example = "Hello World";

            for(int i =0; i < example.Length; i++)
            {
                Console.WriteLine(example.Substring(1, 1));
            }
        }

        public void DivisibleByThree()
        {
            string example = "Hello World";

            for(int i = 0; i <example.Length; i++)
            {
                Console.WriteLine(example[i % 3]);
            }
        }


    }
}
