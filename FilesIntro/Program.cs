using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg1();
            //Opg2();
            //Opg3();
            Opg4();

            string test = "test,";

            string[] test2 = test.Split(',');
            Console.ReadLine();
        }

        static void Opg1()
        {
            StreamWriter myFile = null;

            try
            {
                myFile = File.CreateText("text.txt");

                Console.Write("Skriv noget:");
                string input = Console.ReadLine();

                myFile.WriteLine(input);
            }
            catch (Exception err) { }
            finally
            {
                if (myFile != null)
                    myFile.Close();
            }
        }

        static void Opg2()
        {
            StreamReader sr = null;

            try
            {
                sr = new StreamReader("text.txt");

                string contents = sr.ReadToEnd();

                Console.WriteLine("Contents of text.txt: {0}", contents);
            }
            catch (Exception err) { }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }

        static void Opg3()
        {
            string[] prog = {"C#","Java","C++","C","Delphi","JavaScript","PHP","ASP:NET","Pascal","Fortran","Lisp"};
            StreamWriter myFile = null;

            try
            {
                myFile = File.CreateText("prog_languages.txt");

                foreach (string item in prog)
                {
                    myFile.WriteLine(item);
                }
            }
            catch (Exception err) { }
            finally
            {
                if (myFile != null)
                    myFile.Close();
            }
        }

        static void Opg4()
        {
            StreamReader sr = null;
                        
            try
            {
                sr = new StreamReader("prog_languages.txt");

                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }            
            }
            catch (Exception err) { }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
        }

    }
}
