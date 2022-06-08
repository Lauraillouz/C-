using System;
using System.IO;

namespace Challenge
{
    class Program
    {

        static void Main(string[] args)
        {
            // read from input.text line by line
            string[] wholeText = File.ReadAllLines(@"/Users/Woodyla/Desktop/WebProjects/C#/14.TextFile/input.txt");


            // split every line that contains "split"
            foreach(string line in wholeText)
            {
                if (line.Contains("split"))
                {
                    // if contains split, get the index 4
                    string[] splitLines = line.Split();
                    string wordToSave = splitLines[4] + " ";

                    File.AppendAllText(@"/Users/Woodyla/Desktop/WebProjects/C#/14.TextFile/output.txt", wordToSave);
                }
            }

            Console.WriteLine(File.ReadAllText(@"/Users/Woodyla/Desktop/WebProjects/C#/14.TextFile/output.txt"));
            File.WriteAllText(@"/Users/Woodyla/Desktop/WebProjects/C#/14.TextFile/output.txt", String.Empty);
        }
    }
}
