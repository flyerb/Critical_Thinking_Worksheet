using System;
using System.Collections.Generic;
using System.Text;

namespace Critical_Thinking_Worksheet
{
    class Calculator_Maddness
    {
        
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
           
            //Console.WriteLine("Enter your first number");
            //int numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your second number.");
            //int numberTwo = int.Parse(Console.ReadLine());

           int result = numberOne + numberTwo;
            return result;
            Console.WriteLine($"The result of this addition is {result}.");
        }

        public void RunCalculations()
        {

            Console.WriteLine("Enter your first number to add");
            int valueOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number to add.");
            int valueTwo = int.Parse(Console.ReadLine());

            int output = AddTwoNumbers(valueOne, valueTwo);
            Console.WriteLine($"The result is {output}");

            Console.WriteLine("Enter your third number to add");
            int valueThree = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your fourth number to add.");
            int valueFour = int.Parse(Console.ReadLine());

            int output2 = AddTwoNumbers(valueThree, valueFour);
            Console.WriteLine($"The result is {output}");

            int output3 = AddTwoNumbers(output, output2);
            Console.WriteLine($"These two calculations added together = {output3}");

        }
    }
}
