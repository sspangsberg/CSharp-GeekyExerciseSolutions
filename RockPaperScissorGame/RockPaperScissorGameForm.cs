using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorGame
{
    public partial class RockPaperScissorGameForm : Form
    {
        RockPaperScissorEngine engine = new RockPaperScissorEngine();

        public RockPaperScissorGameForm()
        {
            InitializeComponent();

            UpdateStats();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            string playerChoice = "";

            if (rbPaper.Checked)
                playerChoice = "PAPER";
            else if (rbScissor.Checked)
                playerChoice = "SCISSOR";
            else if (rbRock.Checked)
                playerChoice = "ROCK";

            string result = engine.Play(playerChoice);

            rbCompRock.Checked = true;
            if (engine.ComputerChoice == "PAPER")
                rbCompPaper.Checked = true;
            else if (engine.ComputerChoice == "SCISSOR")
                rbCompScissor.Checked = true;


            if (result == playerChoice)
            {
                pbResult.Show();
                pbResult.Image = Properties.Resources.victory;

                engine.TotalUserWins++;
            }
            else
            {
                pbResult.Hide();
                engine.TotalComputerWins++;
            }

            UpdateStats();
        }

        private void UpdateStats()
        {
            lblCPUWins.Text =  engine.TotalComputerWins + " (Computer sejre)";
            lblPlayerWins.Text = engine.TotalUserWins + " (Dine sejre)";
            lblPaperWins.Text = engine.TotalPaperWins + " (Papir sejre)";
            lblRockWins.Text = engine.TotalRockWins + " (Sten sejre)";
            lblScissorWins.Text = engine.TotalScissorWins + " (Sakse sejre)";
        }
    }
}
