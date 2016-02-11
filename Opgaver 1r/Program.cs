using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Opgaver_1r
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Checking if a file exists
            if (File.Exists("MyFile.txt"))
            {
                Console.WriteLine("File exist");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            */

            /*

            //Creating a new directory (folder)
            Directory.CreateDirectory("MySubDir");



            //Creating a new file
            File.Create("MyFile.txt");



            //Copying a file
            File.Copy("MyFile.txt", "MyFile2.txt", true);

            //Note the third argument in the above Copy method is used to indicate whether the [second]
            //file should be overwritten or not if it already exists.
            


            //Delete a file
            File.Delete("MyFile2.txt");



            //Moving a file
            File.Move("MyFile.txt", "MySubDir\\MyMovedFile.txt");

            string path = "C:\\MyDir\\";

            //Listing files in a directory
            string[] files = Directory.GetFiles(path);
            foreach (String f in files)
            {
                Console.WriteLine(f);
            }

            //Listing sub directories in a directory
            string[] dirs = Directory.GetDirectories(FILE_DIR);
            foreach (String d in dirs)
            {
                Console.WriteLine(d);
            }

            //Writing text to a text file
            StreamWriter myFile = File.CreateText("MyFile.txt");
            myFile.WriteLine("This text will be stored in a text file");
            myFile.Close();

            //Appending text to a text file
            StreamWriter myFile = File.AppendText("MyFile.txt");
            myFile.WriteLine("This text will be appended to the file");
            myFile.Close();

            //Reading from a text file
            string s;
            StreamReader myFile = File.OpenText("MyFile.txt");
            while ((s = myFile.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            myFile.Close();




            */









            /*

            if (File.Exists("minFil.txt"))
            {
                Console.WriteLine("File exist");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }


            */
            
            /*
            StreamReader myFile = null;
            List<string> contents = new List<string>();

            try
            {
                myFile = new StreamReader("myFile.txt");
                
                while (myFile.EndOfStream)
                {
                    contents.Add(myFile.ReadLine());
                }
               
                Console.WriteLine(contents);
            }
            catch (Exception err) { }
            finally {
                if (myFile != null)
                    myFile.Close();
            }
            */

            
            StreamWriter myFile = null;
            List<string> contents = new List<string>();
            
            try
            {
                myFile = File.CreateText("myFile.txt");

                foreach (string line in contents)
                {
                    myFile.WriteLine(line);
                }                
            }
            catch (Exception err)  {}
            finally 
            {
                if (myFile != null)
                    myFile.Close(); 
            }
            


            //opg5();

            Console.ReadLine();
        }

        static void opg1()
        {
            double length = 10.5;
            double width = 20.4;
            double height = 56;

            double result = length * width * height;

            Console.WriteLine("Rumfanget er: {0}", result);
        }

        static void opg2()
        {
            double x = 4;
            double y = 7;

            Console.WriteLine("X + Y: {0}", x * y);
            Console.WriteLine("X - Y: {0}", x - y);
            Console.WriteLine("X * Y: {0}", x * y);
            Console.WriteLine("X / Y: {0}", x / y);
        }

        static void opg3()
        {
            Console.Write("Indtast dit fornavn:");
            string firstName = Console.ReadLine();
            
            Console.Write("Indtast dit efternavn:");            
            string lastName = Console.ReadLine();
            
            Console.Write("Indtast din email:");
            string email = Console.ReadLine();

            Console.WriteLine("Dine oplysninger:\n");
            Console.WriteLine("Navn: {0} {1}", firstName, lastName);
            Console.WriteLine("Email: {0}", email);

        }

        static void opg4()
        {
            string text = "ABCDEFG";

            Console.WriteLine("Placering af B:", text.IndexOf("B"));
            Console.WriteLine("Placering af FG:", text.IndexOf("FG"));
            Console.WriteLine("Store bogstaver:", text.ToUpper());

            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));                      

        }

        static void opg5()
        {
            string white = "hvid";
            string black = "black";

            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.Write(white + "-");
                    Console.Write(black + "-");
                }
                Console.WriteLine();
                for (int k = 0; k < 4; k++)
                {
                    Console.Write(black + "-");
                    Console.Write(white + "-");
                }
                Console.WriteLine();
            }         
            Console.WriteLine();

        }
    }
}
