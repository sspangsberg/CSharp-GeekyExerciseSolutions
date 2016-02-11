using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorGame
{
    class RockPaperScissorEngine
    {
        public int TotalRockWins { get; set; }
        public int TotalScissorWins { get; set; }
        public int TotalPaperWins { get; set; }
        public int TotalDraws { get; set; }

        public int TotalUserWins { get; set; }
        public int TotalComputerWins { get; set; }

        public string ComputerChoice { get; set; }


        public string Play(string playersChoice)
        {
            Random rnd = new Random();            
            string result = "";

            int rndNumber = rnd.Next(1, 4);

            if (rndNumber == 1) //Rock
                ComputerChoice = "ROCK";
            else if (rndNumber == 2)
                ComputerChoice = "PAPER";
            else
                ComputerChoice = "SCISSOR";

            result = DetermineResult(playersChoice.ToUpper(), ComputerChoice.ToUpper());

            return result;
        }


        private string DetermineResult(string choice1, string choice2)
        {
            if (choice1 == "ROCK" && choice2 == "SCISSOR")
            {
                TotalRockWins++;
                return choice1;
            }
            else if (choice1 == "ROCK" && choice2 == "PAPER")
            {
                TotalPaperWins++;
                return choice2;
            }
            else if (choice1 == "ROCK" && choice2 == "ROCK")
            {
                TotalDraws++;
                return "DRAW";
            }
            else if (choice1 == "PAPER" && choice2 == "SCISSOR")
            {
                TotalScissorWins++;
                return choice2;
            }
            else if (choice1 == "PAPER" && choice2 == "PAPER")
            {
                TotalDraws++;
                return "DRAW";
            }
            else if (choice1 == "PAPER" && choice2 == "ROCK")
            {
                TotalPaperWins++;
                return choice1;
            }
            else if (choice1 == "SCISSOR" && choice2 == "SCISSOR")
            {
                TotalDraws++;
                return "DRAW";
            }
            else if (choice1 == "SCISSOR" && choice2 == "PAPER")
            {
                TotalScissorWins++;
                return choice1;
            }

            else if (choice1 == "SCISSOR" && choice2 == "ROCK")
            {
                TotalRockWins++;
                return choice2;
            }
            else
                return "FAIL";

        }           
    }
}
