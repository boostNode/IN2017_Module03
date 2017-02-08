/*
 *  Author: Troy Davis
 *  Project: FortuneTeller - Console (Chapter 7, Programming Exercise 5)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 5, 2017 
 *  Revision: Original
 */

using System;

namespace FortuneTeller
{
    class Program
    {
        //  begin Main
        static void Main(string[] args)
        {
            // class scope variables
            int[] intArrayIndices = new int[2];  // array size drives the number of fortunes to display

            String[] strArrayFortunes = new String[] {  "I see a tall, dark stranger in your future.",
                                                        "Your future holds vast improvements in your C# programming skills!",
                                                        "Your computer will soon be infected with a horrible virus!",
                                                        "A difficult programming challenge will soon be presented to you!",
                                                        "An iterative ... an iterative ... an iterative loop will plague you!",
                                                        "Powerful you have become, the dark side I sense in you." };

            bool boolFoundUniqueIndex;
            int intRandomNumber;
            Random ranNumberGenerator = new Random();

            // initialize console
            Console.WriteLine("Fortune Teller");
            Console.Write("\n\tPress 'Enter' to get your fortunes: "); Console.ReadLine();

            // get random (but different, non-repeat) indices to strArrayFortunes
            //      note: this method allows computation and storage of a variable number of indices
            //      to the strArrayFortunes dependent on the size (length) of the intArrayIndices array
            //
            // baseline test, length of intArrayIndices can't be longer than length of strArrayFortunes if unique indices are required
            if ( intArrayIndices.Length <= strArrayFortunes.Length )
            {
                // intialize intArrayIndices with invalid array indices
                for ( int i = 0 ; i < intArrayIndices.Length ; i++ )
                {
                    intArrayIndices[i] = -1; // invalid array index, will replace in next loop
                }
                // get valid indices to strArrayFortunes
                for ( int i = 0 ; i < intArrayIndices.Length ; i++ )
                {
                    // compute random index and test it against entire indices array for match, loop until a unique value is found
                    do
                    {
                        boolFoundUniqueIndex = true;
                        intRandomNumber = ranNumberGenerator.Next(0, strArrayFortunes.Length);
                        for ( int j = 0 ; j < intArrayIndices.Length ; j++ )
                        {
                            if( intRandomNumber == intArrayIndices[j] )
                            {
                                boolFoundUniqueIndex = false;
                            }
                        }
                    } while ( boolFoundUniqueIndex == false );
                    // set random index
                    intArrayIndices[i] = intRandomNumber;
                }
                // display fortunes
                DisplayFortunes(intArrayIndices, strArrayFortunes);
            }
            else
            {
                Console.WriteLine("\n\tError: I can't compute that many unique fortunes for you!");
            }
            // wait on user to close console
            Console.Write("\n\tPress 'Enter' to exit: "); Console.ReadLine();
        }
        //  end Main

        //  begin DisplayFortunes
        //
        //      Inputs:
        //          int[]       indices     an integer array containing indices into the String[] fortunes
        //          String[]    fortunes    a String array containing fortune statements      
        //
        //      Outputs:
        //          Displays a number of fortunes based on the number of indices provided
        //
        private static void DisplayFortunes(int[] indices, String[] fortunes)
        {
            for (int index = 0; index < indices.Length; index++)
            {
                if ( indices[index] < fortunes.Length ) {// test for invalid index, display fortune if index is valid
                    Console.WriteLine("\n\t- " + fortunes[indices[index]]);
                }
                else
                {// display error message if index is invalid
                    Console.WriteLine("\n\t- Error: invalid index");
                }
            }
        }
        //  end DisplayFortunes
    }
}
