using System;

namespace IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a practice iternation while loop that I did in class on 9-10-2019. 
            Console.Write("Please Enter Time: ");
            string input = Console.ReadLine();
            int value_input = int.Parse(input);
            try
            {
                if ((value_input > 1) && (value_input <= 10));
                {
                    Console.WriteLine("Display Interview Times");
                    Console.WriteLine("This message will iterate from " + value_input.ToString() + " O'Clock");
                    while (value_input > 0)
                    {
                        Console.WriteLine("Iteration:" + value_input.ToString());
                        value_input--;
                    }
                   
                }
   
            }
            catch
            {
                Console.WriteLine("Please try running loop again");
                Console.WriteLine("PressKey to Exit");
                Console.ReadKey(true);
            }
 
          
        }
    }
}
