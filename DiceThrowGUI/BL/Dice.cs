#region Imports

//C# imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace DiceThrowGUI.BL
{
    class Dice
    {
        #region Class Variables

        private int eyeValue;
        private int numberOfSides;
        private Random rnd = new Random();

        #endregion

        #region Class Properties
        
        public int EyeValue
        {
            get { return eyeValue; }
            set { eyeValue = value; }
        }
             

        public int NumberOfSides
        {
            get { return numberOfSides; }
            set { numberOfSides = value; }
        }

        #endregion

        #region Class Methods

        public Dice() { numberOfSides = 6; }

        public Dice(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
        }


        public void ThrowDice()
        {
            eyeValue = rnd.Next(1, numberOfSides + 1);
        }

        public override string ToString()
        {
            return string.Format("The dice has {0} sides and landed on {1}", numberOfSides, eyeValue);
        }

        #endregion
    }
}
