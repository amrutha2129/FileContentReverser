using System;
using System.IO;

namespace FileContentReverser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accepting the path of the file from which the contents have to be read 
            Console.WriteLine("Please enter the file path from where the contents have to be read");
            var fileContents = File.ReadAllText(Console.ReadLine());

            // Calling the function to reverse the file contents
            IReverser reverser = new Reverser();
            var reversed = reverser.Reverse(fileContents);

            Console.WriteLine("Please enter the file path to where the reversed content should be written");
            // Writing the reversed contents to the file
            File.WriteAllText(Console.ReadLine(), reversed);
        }
    }
}
