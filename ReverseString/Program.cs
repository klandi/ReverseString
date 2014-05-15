using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseString
{
    class Program
    {
        //Reversing a string without creating a new string object
        //just as a proof of concept
        static void Main(string[] args)
        {   
            string myStr = "one two three";
            
            Console.WriteLine("Sample Input: {0}", myStr);
            Console.WriteLine("Order Inverted: {0}\n", reverseString(myStr));

            string strResult = _T("Type a phrase");
            Console.WriteLine("Order Inverted: {0}", reverseString(strResult));

            Console.ReadKey();
        }

        // Provides the prompt to get the string from the user
        static protected string _T(string prompt)
        {
            Console.Write(prompt + " : ");
            return Console.ReadLine();
        }

        static StringBuilder reverseString(string inputString)
        {
            StringBuilder myStr = new StringBuilder(inputString);

            int len = myStr.Length;
            int i = 0;
            char lastChar;           

            // First Step: Flip the string completely
            while (i < len / 2)
            {
                lastChar = myStr[len - (i + 1)];
                myStr[len - (i + 1)] = myStr[i];
                myStr[i] = lastChar;
                i++;
            }
            
            //Console.WriteLine("Reversed: {0}", myStr);

            int startIndex = 0;
            i = 0;

            // Second Step: Start reversing each word in the string
            while (myStr.ToString().IndexOf(" ", startIndex) > 0 || startIndex - 1 == myStr.ToString().LastIndexOf(" "))
            {
                if (myStr.ToString().IndexOf(" ", startIndex) > 0)
                    len = myStr.ToString().IndexOf(" ", startIndex) - startIndex;
                else
                    len = myStr.Length - startIndex;

                while (i < len / 2)
                {
                    lastChar = myStr[startIndex + len - (i + 1)];
                    myStr[startIndex + len - (i + 1)] = myStr[startIndex + i];
                    myStr[i + startIndex] = lastChar;
                    i++;
                }
                if (startIndex - 1 == myStr.ToString().LastIndexOf(" "))
                    break;
                else
                    startIndex = startIndex + len + 1;

                i = 0;
            }
            return myStr;
        }
    }
}
