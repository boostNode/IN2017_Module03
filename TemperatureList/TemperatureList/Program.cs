/*
 *  Author: Troy Davis
 *  Project: TemperatureList (Chapter 6, Programming Exercise 2)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 2, 2017 
 *  Revision: Original
 */

using System;

namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            // class scope variables
            String strFeedback = "";
            String strInput;

            int intLoopCounter = 0;

            int[] intArrayTemps = new int[7];// size of this array will determine number of temperatures to input

            int intSumTemps = 0;
            double dblAverageTemp;

            // initialize console
            Console.WriteLine("Temperature List");

            // initiate input loop
            do
            {
                // get user input
                do
                {
                    // get user input
                    Console.Write("\n\t" + strFeedback + "Enter a high temperature: ");
                    strInput = Console.ReadLine();

                    // validate user input
                    strFeedback = "";
                    if (!Int32.TryParse(strInput, out intArrayTemps[intLoopCounter])) // parse input to Int32, handle non-numeric input
                    {
                        strFeedback = "Invalid Input! ";
                    }

                } while ( strFeedback != "" );

                // increment loop counter
                intLoopCounter += 1;

            } while ( intLoopCounter < intArrayTemps.Length );

            // compute average temperature
            foreach (int temp in intArrayTemps)
            {
                intSumTemps += temp;
            }
            dblAverageTemp = (double)intSumTemps / (double)intArrayTemps.Length; // NOTE: no error handling for '0' length array

            // provide feedback on average temperature and temp difference
            Console.WriteLine("\nThe average temperature was {0} degrees.", dblAverageTemp.ToString("F1"));
            for ( int i = 0 ; i < intArrayTemps.Length; i++ )
            {
                if( (double)intArrayTemps[i] < dblAverageTemp )
                {
                    Console.WriteLine("\n\tTemperature[{0}]: {1} degrees -- {2} degrees below average", i, intArrayTemps[i], (dblAverageTemp - (double)intArrayTemps[i]).ToString("F1"));
                }
                else if( (double)intArrayTemps[i] > dblAverageTemp )
                {
                    Console.WriteLine("\n\tTemperature[{0}]: {1} degrees -- {2} degrees above average", i, intArrayTemps[i], ((double)intArrayTemps[i] - dblAverageTemp).ToString("F1"));
                }
                else // ==
                {
                    Console.WriteLine("\n\tTemperature[{0}]: {1} degrees -- same as average", i, intArrayTemps[i]);
                }
            }

            // wait on user to close console
            Console.Write("\n\t"); Console.ReadLine();
        }
    }
}
