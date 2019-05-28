using System;
using System.Collections.Generic;
using System.Text;

namespace FileContentReverser
{
    public class Reverser : IReverser
    {
        
        public string Reverse(string text)
        {
            var lines = text.Split(Environment.NewLine);
            var output = new StringBuilder(lines.Length);
            Array.Reverse(lines);
            foreach (var line in lines)
            {
                var characters = line.ToCharArray();
                Array.Reverse(characters);
                var reversedLine = new string(characters);
                output.AppendLine(reversedLine);
            }

            return output.ToString().TrimEnd('\r','\n');
        }
    }
}
