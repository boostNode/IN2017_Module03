/*
 *  Author: Troy Davis
 *  Project: CheckZips - Console (Chapter 6, Programming Exercise 4)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 2, 2017 
 *  Revision: Original
 */

using System;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            // class scope variables
            String strFeedback = "";
            String strInput;
            int intInput;
            bool boolSupported = false;

            String[] strArrayDeliveryZips = new String[] {  "67201",
                                                            "67202",
                                                            "67203",
                                                            "67204",
                                                            "67205",
                                                            "67206",
                                                            "67207",
                                                            "67208",
                                                            "67209",
                                                            "67210" };

            // initialize console
            Console.WriteLine("Check Zips");

            // get user input
            do
            {
                // get user input
                Console.Write("\n\t" + strFeedback + "Enter the delivery zipcode (5 digits): ");
                strInput = Console.ReadLine();

                // validate user input
                strFeedback = "";
                if ( strInput.Length != 5 || !Int32.TryParse(strInput, out intInput) ) // check for correct length, all digits
                {
                    strFeedback = "Invalid Input; must be 5 digits!\n\n\t";
                }

            } while (strFeedback != "");

            // output message on delivery support
            foreach( String zip in strArrayDeliveryZips )
            {
                if( strInput == zip )
                {
                    boolSupported = true;
                }
            }
            if( boolSupported )
            {
                Console.WriteLine("\nThe zipcode {0} is within the company's delivery area!", strInput);
            }
            else
            {
                Console.WriteLine("\nSorry, the zipcode {0} is not within the company's delivery area!", strInput);
            }

            // wait on user to close console
            Console.Write("\n\t"); Console.ReadLine();
        }
    }
}
