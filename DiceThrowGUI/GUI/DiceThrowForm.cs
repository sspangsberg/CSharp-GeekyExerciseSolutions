#region Imports

//C# imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Project imports
using DiceThrowGUI.BL;

#endregion

namespace DiceThrowGUI.GUI
{
    public partial class DiceThrowForm : Form
    {
        Dice d = new Dice();

        public DiceThrowForm()
        {
            InitializeComponent();
        }

        private void btnThrowDice_Click(object sender, EventArgs e)
        {
            d.ThrowDice();

            switch (d.EyeValue)
            {
                case 1:
                    pbResult.Image = Properties.Resources.dice_one;
                    break;
                case 2:
                    pbResult.Image = Properties.Resources.dice_two;
                    break;
                case 3:
                    pbResult.Image = Properties.Resources.dice_three;
                    break;
                case 4:
                    pbResult.Image = Properties.Resources.dice_four;
                    break;
                case 5:
                    pbResult.Image = Properties.Resources.dice_five;
                    break;
                case 6:
                    pbResult.Image = Properties.Resources.dice_six;
                    break;

                default:
                    break;
            }
         
        }
    }
}
