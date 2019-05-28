using System;
using System.Collections.Generic;
using System.Text;

namespace FileContentReverser
{
    public class Reverser : IReverser
    {
        //Function that accepts a string and returns its reversed value
        public string Reverse(string text)
        {
            //convert to array
            char[] strArray = text.ToCharArray();

            //reverse the array
            Array.Reverse(strArray);

            //again convert to string
            string reverseString = new string(strArray);

            return reverseString;

        }
    }
}
