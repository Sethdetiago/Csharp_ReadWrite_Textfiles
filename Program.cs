using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write to a text file
            string[] input = { "Hello,", "", "This text file was created by an", "external program" };
            System.IO.File.WriteAllLines(@"C:\Users\seths\source\repos\FileIOCS\Assets\Writtentextfile.txt", input);

            //Get user input to create a file, name it and write to it.

            Console.WriteLine("Please choose a name for your text file");
            string textFileName = Console.ReadLine();

            Console.WriteLine("What would you like to write to the file?");
            string textContents = Console.ReadLine();

            System.IO.File.WriteAllText(@"C:\Users\seths\source\repos\FileIOCS\Assets\" + textFileName + ".txt", textContents);
            
            //Use a streamwriter
            using(StreamWriter file = new StreamWriter(@"C:\Users\seths\source\repos\FileIOCS\Assets\myText.txt"))
            {
                foreach(string line in input)
                { 
                    if (line.Contains("text"))
                        {
                        file.WriteLine(line);
                        }
                    //Wries "This text file was created by an" to he file
                }
                
            }

            string text = System.IO.File.ReadAllText(@"C:\\Users\\seths\\source\\repos\\FileIOCS\\Assets\\TextFile.txt");
            //Contents of the file are stored in the string Text  which is accessed in the following line
            Console.WriteLine(text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\\Users\\seths\\source\\repos\\FileIOCS\\Assets\\TextFile.txt");
            Console.WriteLine(lines[1]);


            Console.ReadKey();
        }
    }
}
