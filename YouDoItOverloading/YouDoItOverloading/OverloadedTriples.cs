/*
 *  Author: Troy Davis
 *  Project: YouDoItOverloading - Console (Chapter 8, You Do It, p331-2)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 5, 2017 
 *  Revision: Original
 */

using System;

namespace YouDoItOverloading
{
    class OverloadedTriples
    {
        //  begin Main
        static void Main(string[] args)
        {
            // class scope variables
            int num = 20;
            String message = "Go team!";

            // initialize console
            Console.WriteLine("You Do It - Overloading Methods");

            // perform output (overloading display)
            Triple(num);
            Triple(message);

            // wait on user to close console
            Console.Write("\n\tPress 'Enter' to exit: "); Console.ReadLine();
        }
        //  end Main

        //  begin Triple(int num)
        //
        //      Inputs:
        //          int     num     an integer to display    
        //
        //      Outputs:
        //          Displays an integer number 3 times
        //
        private static void Triple(int num)
        {
            const int MULT_FACTOR = 3;
            Console.WriteLine("\n\t{0} times {1} is {2}", num, MULT_FACTOR, num * MULT_FACTOR);
        }
        //  end Triple(int num)

        //  begin Triple(String message)
        //
        //      Inputs:
        //          int     num     an integer to display    
        //
        //      Outputs:
        //          Displays an integer number 3 times
        //
        private static void Triple(String message)
        {
            Console.WriteLine("\n\t{0}\t{0}\t{0}", message);
        }
        //  end Triple(String message)
    }
}
