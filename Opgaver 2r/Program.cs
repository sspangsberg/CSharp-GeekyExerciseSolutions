using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgaver_2r
{
    class Program
    {
        static void Main(string[] args)
        {
            opg2();

            Console.ReadLine();
        }

        static void opg1()
        {            
            string[] instruments = {"cello","guitar","violin","tværfløjte","gulvbas"};

            for (int i = 0; i < instruments.Length; i++)
            {
                string tmp = "";
                
                tmp = instruments[i].Replace("a", "")
                   .Replace("e", "")
                   .Replace("i", "")
                   .Replace("o", "")
                   .Replace("u", "")
                   .Replace("y", "")
                   .Replace("æ", "")
                   .Replace("ø", "")
                   .Replace("å", "");                               

                instruments[i] = tmp;
            }

            foreach (string item in instruments)
            {
                Console.WriteLine(item);
            }
        }

        static void opg2()
        {
            int MMORPG = 0;
            int SG = 0;
            int MOBAG = 0;
            int FSTPSG = 0;
            int PG = 0;
            int CG = 0;

            string[] games = { "World of WarCraft – MMORPG",
                               "The Elder Scrolls Online – MMORPG",
                               "StarCraft - SG",
                               "League of Legends - MOBAG",
                               "Wolfenstein - FSTPS",
                               "Super Mario Bros. - PG",
                               "EverQuest – MMORPG",
                               "Age of Empires - SG",
                               "Need for Speed - CG" };

            for (int i = 0; i < games.Length; i++)
            {
                string g = games[i];

                if (g.IndexOf("MMORPG") != -1)
                    MMORPG++;
                else if (g.IndexOf("SG") != -1)
                    SG++;
                else if (g.IndexOf("MOBAG") != -1)
                    MOBAG++;
                else if (g.IndexOf("FSTPS") != -1)
                    FSTPSG++;
                else if (g.IndexOf("CG") != -1)
                    CG++;
                else if (g.IndexOf("PG") != -1)
                    PG++;
            }            
        }

        static void opg3()
        {
            string matches = @"Manchester United 1 Chelsea 0, 
                               Arsenal 1 Manchester United 1, 
                               Manchester United 3 Fulham 1,
                               Liverpool 2 Manchester United 1,
                               Swansea 2 Manchester United 4";

            string[] matchesArr = matches.Split(',');

            
        }
    }
}
