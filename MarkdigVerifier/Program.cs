using System;
using System.IO;

namespace MarkdigVerifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Markdig Verifier");

            Console.WriteLine("Enter path to Markdown file.");
            string inputPath = Console.ReadLine();
            string outputPath = inputPath + ".html";

            Console.WriteLine(string.Format("Reading {0}", inputPath));

            string fileContent = File.ReadAllText(inputPath);

            //Console.WriteLine(fileContent);

            string htmlContent = MarkdownConverter.Parse(fileContent);

            Console.WriteLine("Conversion Complete, writing to " + outputPath);

            File.WriteAllText(outputPath, htmlContent);

            Console.WriteLine("Finished, hit [enter] to quit.");
            Console.ReadLine();

        }
    }
}
