using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petals_Around_The_Rose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes the text from txtbxGuess and sends it to be checked for the correct answer at checkGuess(guess)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(txtbxGuess.Text);
            checkGuess(guess);
        }

        int totCorrect;
        /// <summary>
        /// Checks if the guess is the same as the solution, if it is then it dispalys CORRECT, if not then it will display what the answer is and that your guess was incorrect
        /// then if you are correct it will add to the totCorrect var and display that value in the text box txtbxNumCorrect to display how many you have gotten correct
        /// then it will add to bestRun and display that value to the text box txtbxBestRun to display how many in a row youhave gotten correct
        /// if you got the answer wrong it will reset the bestRun to 0 and dispaly it.
        /// </summary>
        /// <param name="guess"></param>
        public void checkGuess(int guess)
        {
            if (guess == solution)
            {
                txtbxResult.Text = "CORRECT!";
                totCorrect++;
                txtbxNumCorrect.Text = string.Format("{0}", totCorrect);
                checkBestRun();
            }
            else
            {
                bestRunCounter = 0;
                txtbxResult.Text = string.Format("It's {0}, not {1}.", solution, guess);
            }
        }

        int bestRun;
        int bestRunCounter;
        /// <summary>
        /// Checks if the current win streak is better than the last bestRun
        /// </summary>
        public void checkBestRun()
        {
            bestRunCounter++;
            if (bestRunCounter == bestRun || bestRunCounter > bestRun)
            {
                bestRun = bestRunCounter;
                txtbxBestRun.Text = string.Format("{0}", bestRun);
            }
        }

        int dice1, dice2, dice3, dice4, dice5;
        /// <summary>
        /// Rolls the dice with a random value of 1 to 6, then sends those dice rolls to setDisplays(dice1, dice2, dice3, dice4, dice5) 
        /// and setSolution(dice1, dice2, dice3, dice4, dice5). totRollsDisplayed method will also be ran.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            dice1 = random.Next(1, 7);
            dice2 = random.Next(1, 7);
            dice3 = random.Next(1, 7);
            dice4 = random.Next(1, 7);
            dice5 = random.Next(1, 7);

            setDisplays(dice1, dice2, dice3, dice4, dice5);
            totRollsDisplay();
            setSolution(dice1, dice2, dice3, dice4, dice5);
        }

        /// <summary>
        /// Takes the random dice rolls and shows the correct image above the correct dice and also displays the die number in the text box
        /// </summary>
        /// <param name="dice1"></param>
        /// <param name="dice2"></param>
        /// <param name="dice3"></param>
        /// <param name="dice4"></param>
        /// <param name="dice5"></param>
        public void setDisplays(int dice1, int dice2, int dice3, int dice4, int dice5)
        {
            switch (dice1)
            {
                case 1:
                    picBoxOne.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice1.png";
                    txtbxDiceOne.Text = "1";
                    break;

                case 2:
                    picBoxOne.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice2.png";
                    txtbxDiceOne.Text = "2";
                    break;

                case 3:
                    picBoxOne.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice3.png";
                    txtbxDiceOne.Text = "3";
                    break;

                case 4:
                    picBoxOne.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice4.png";
                    txtbxDiceOne.Text = "4";
                    break;

                case 5:
                    picBoxOne.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice5.png";
                    txtbxDiceOne.Text = "5";
                    break;

                case 6:
                    picBoxOne.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice6.png";
                    txtbxDiceOne.Text = "6";
                    break;
            }

            switch (dice2)
            {
                case 1:
                    picBoxTwo.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice1.png";
                    txtbxDiceTwo.Text = "1";
                    break;

                case 2:
                    picBoxTwo.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice2.png";
                    txtbxDiceTwo.Text = "2";
                    break;

                case 3:
                    picBoxTwo.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice3.png";
                    txtbxDiceTwo.Text = "3";
                    break;

                case 4:
                    picBoxTwo.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice4.png";
                    txtbxDiceTwo.Text = "4";
                    break;

                case 5:
                    picBoxTwo.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice5.png";
                    txtbxDiceTwo.Text = "5";
                    break;

                case 6:
                    picBoxTwo.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice6.png";
                    txtbxDiceTwo.Text = "6";
                    break;
            }

            switch (dice3)
            {
                case 1:
                    picBoxThree.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice1.png";
                    txtbxDiceThree.Text = "1";
                    break;

                case 2:
                    picBoxThree.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice2.png";
                    txtbxDiceThree.Text = "2";
                    break;

                case 3:
                    picBoxThree.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice3.png";
                    txtbxDiceThree.Text = "3";
                    break;

                case 4:
                    picBoxThree.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice4.png";
                    txtbxDiceThree.Text = "4";
                    break;

                case 5:
                    picBoxThree.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice5.png";
                    txtbxDiceThree.Text = "5";
                    break;

                case 6:
                    picBoxThree.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice6.png";
                    txtbxDiceThree.Text = "6";
                    break;
            }

            switch (dice4)
            {
                case 1:
                    picBoxFour.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice1.png";
                    txtbxDiceFour.Text = "1";
                    break;

                case 2:
                    picBoxFour.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice2.png";
                    txtbxDiceFour.Text = "2";
                    break;

                case 3:
                    picBoxFour.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice3.png";
                    txtbxDiceFour.Text = "3";
                    break;

                case 4:
                    picBoxFour.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice4.png";
                    txtbxDiceFour.Text = "4";
                    break;

                case 5:
                    picBoxFour.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice5.png";
                    txtbxDiceFour.Text = "5";
                    break;

                case 6:
                    picBoxFour.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice6.png";
                    txtbxDiceFour.Text = "6";
                    break;
            }

            switch (dice5)
            {
                case 1:
                    picBoxFive.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice1.png";
                    txtbxDiceFive.Text = "1";
                    break;

                case 2:
                    picBoxFive.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice2.png";
                    txtbxDiceFive.Text = "2";
                    break;

                case 3:
                    picBoxFive.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice3.png";
                    txtbxDiceFive.Text = "3";
                    break;

                case 4:
                    picBoxFive.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice4.png";
                    txtbxDiceFive.Text = "4";
                    break;

                case 5:
                    picBoxFive.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice5.png";
                    txtbxDiceFive.Text = "5";
                    break;

                case 6:
                    picBoxFive.ImageLocation = "C:\\Users\\mouge\\source\\repos\\Petals Around The Rose\\Petals Around The Rose\\Resources\\dice6.png";
                    txtbxDiceFive.Text = "6";
                    break;
            }
        }

        int totRolls = 1;
        /// <summary>
        /// Just adds to the text box txtbxTotRolls to show the total times you've rolled the dice.
        /// </summary>
        public void totRollsDisplay()
        {
            txtbxTotRolls.Text = string.Format("{0}", totRolls);
            totRolls++;
        }

        int solution;
        /// <summary>
        /// Gets the dice rolls and adds to the solution if they rolled a 3 or 5 for each die.
        /// </summary>
        /// <param name="dice1"></param>
        /// <param name="dice2"></param>
        /// <param name="dice3"></param>
        /// <param name="dice4"></param>
        /// <param name="dice5"></param>
        public void setSolution(int dice1, int dice2, int dice3, int dice4, int dice5)
        {
            solution = 0;
            switch (dice1)
            {
                case 3:
                    solution += 2;
                    break;

                case 5:
                    solution += 4;
                    break;
            }

            switch (dice2)
            {
                case 3:
                    solution += 2;
                    break;

                case 5:
                    solution += 4;
                    break;
            }

            switch (dice3)
            {
                case 3:
                    solution += 2;
                    break;

                case 5:
                    solution += 4;
                    break;
            }

            switch (dice4)
            {
                case 3:
                    solution += 2;
                    break;

                case 5:
                    solution += 4;
                    break;
            }

            switch (dice5)
            {
                case 3:
                    solution += 2;
                    break;

                case 5:
                    solution += 4;
                    break;
            }
        }
    }
}
