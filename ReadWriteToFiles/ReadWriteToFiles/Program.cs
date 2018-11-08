using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * This is a program that will go over different ways of reading and writing to files.
 * In the future, I'll want to pass byte streams between client and server and pass xml
 *  
 * /
namespace ReadWriteToFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            ReadFiles();
            WriteFile("Generics allow us to have objects inside our Collections methods", "textFile.txt");
            WriteFile("In turn objects can have collections inside them", "textFile.txt");
            WriteFile("#Russiandolls", "textFile.txt");

            Console.WriteLine("After Write:");
            ReadFiles();
            Console.ReadKey();
        }

        private static string getFullPath(String Filename)
        {
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = dir + "\\" + Filename;
            return path;

        }

        private static void WriteFile(String textToAppend, String FileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(getFullPath(FileName), true))
                {
                    writer.WriteLine(textToAppend);
                }
                   
               

            } catch
            {
                throw new FileNotFoundException();
            }

            Console.WriteLine("Wrote to file");

        }
        private async static void ReadFiles()
        {
           
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            string path = getFullPath("textFile.txt");
            Console.WriteLine(path);
            
            
            try {
                using (StreamReader reader = new StreamReader(path))
                {
                    string contents = await reader.ReadToEnd();
                    Console.WriteLine("File Contents:");
                    Console.WriteLine(contents);
                }
                  
                
            } catch
            {
                throw new FileNotFoundException();
            }
           
        }
    }
}
