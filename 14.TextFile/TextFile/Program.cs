using System;
using System.Threading.Tasks;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1: reading text
            string text = File.ReadAllText(@"/Users/Woodyla/Desktop/WebProjects/C#/14.TextFile/textFile.txt");

            Console.WriteLine("Text file contains following text: {0}", text);

            // Example 2: reading lines 
            string[] lines = File.ReadAllLines(@"/Users/Woodyla/Desktop/WebProjects/C#/14.TextFile/textFile.txt");

            Console.WriteLine("Context of textfile.txt = ");
            foreach(string line in lines)
            {
                Console.WriteLine("\t{0}", line);
            }

            // Example 3: Writing in a file (WARNING: this action OVERWRITES anything that was in file before)
            string[] theLines = { "first line", "second line", "third line" };

            File.WriteAllLines("/Users/Woodyla/Desktop/WebProjects/C#/14.TextFile/someLines.txt", theLines);
            foreach (string line in theLines)
            {
                Console.WriteLine("\t{0}", line);
            }

            // Example 4: Create and write in created file
            string[] scores = { "190", "87", "1567", "7166", "77" };
            File.WriteAllLines("/Users/Woodyla/Desktop/WebProjects/C#/14.TextFile/highScores.txt", scores);

            Console.WriteLine("Please give the file a name: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the content of your file: ");
            string input = Console.ReadLine();

            File.WriteAllText(@"/Users/Woodyla/Desktop/WebProjects/C#/14.TextFile/" + fileName + ".txt", input);

            // Example 5
            using (StreamWriter file = new StreamWriter(@"/Users/Woodyla/Desktop/WebProjects/C#/14.TextFile/newText.txt"))
            {
                foreach(string line in theLines)
                {
                    if(line.Contains("third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

        }
    }
}
