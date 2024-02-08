/*
 * author: Magaly Rodriguez
 * course: COMP-003A  
 * purpose: code for lecture activity 4: for loops and while loops
 */

namespace COMP003A.Lectureactivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for-loop statement");
            Console.WriteLine("".PadRight(50, '*'));

            //count 0-9
            int limit = 10; //variable limit for the loop

            /*the for statement executes its boy while a specified Boolean expression 
             * evaluates to true.
             * there are 3 parts in the for loop statement
             * 1. int counter = 0; => loop variable initialization 
             * 2. counter <limit; => condition
             * 3. counter++ => iterator */

            for (int counter = 0; counter < limit; counter++)
            {
                //this code block will execute every loop
                Console.WriteLine($"/t Current counter: {counter}");
            }

            Console.WriteLine("/n"); // /n means new line
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach statement");
            Console.WriteLine("".PadRight(50, '*'));
        }

    }
}
