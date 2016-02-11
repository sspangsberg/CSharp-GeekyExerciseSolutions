using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = new string[6];
            games[0] = "Minecraft";
            games[1] = "World of WarCraft";
            games[2] = "Wolfenstein";
            games[3] = "Wolfenstein 3D";
            games[4] = "Doom";
            games[5] = "Commander Keen";

            Console.WriteLine("Udskrift af array med for....");
            for (int i = games.Length - 1; i > -1; i--)
            {
                Console.WriteLine(games[i]);
                System.Threading.Thread.Sleep(400);//pause i 400 ms
            }


            
            Console.WriteLine("\nUdskrift af array med foreach....");
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }


            

            Console.ReadLine();

        }
    }
}
