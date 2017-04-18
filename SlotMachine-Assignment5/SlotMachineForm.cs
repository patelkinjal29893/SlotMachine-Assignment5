// App Name : SlotMachine Form
// Author Name : Kinjal Patel
// Student ID : 200334364
// App Creation Date : April 3rd, 2017
// App Description : This is displays all different combinations o winning and loosing for Slot Machine Game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine_Assignment5
{
    public partial class SlotMachineForm : Form
    {
        private int playerMoney = 1000;
        private int winnings = 0;
        private int jackpot = 5000;
        private int _currentJackpot;
        private float turn = 0.0f;
        private int playerBet = 0;
        private float winNumber = 0.0f;
        private float lossNumber = 0.0f;
        private string[] spinResult;
        private string fruits = "";
        private float winRatio = 0.0f;
        private float lossRatio = 0.0f;
        private int grapes = 0;
        private int bananas = 0;
        private int oranges = 0;
        private int cherries = 0;
        private int bars = 0;
        private int bells = 0;
        private int sevens = 0;
        private int blanks = 0;

        private Random random = new Random();

        public SlotMachineForm()
        {
            InitializeComponent();
        }

        /* Utility function to show Player Stats */
        private void showPlayerStats()
        {            
            winRatio = winNumber / turn;
            lossRatio = lossNumber / turn;
            string stats = "";
            stats += ("Jackpot: " + jackpot + "\n");
            stats += ("Player Money: " + playerMoney + "\n");
            stats += ("Turn: " + turn + "\n");
            stats += ("Wins: " + winNumber + "\n");
            stats += ("Losses: " + lossNumber + "\n");
            stats += ("Win Ratio: " + (winRatio * 100) + "%\n");
            stats += ("Loss Ratio: " + (lossRatio * 100) + "%\n");
            
            playerBet = 0;
            stats += (TotalCreditsTextBox.Text = Convert.ToString(playerMoney));
            WinnerPaidTextBox.Text = Convert.ToString(winnings);          
        }

        /* Utility function to reset all fruit tallies*/
        private void resetFruitTally()
        {
            grapes = 0;
            bananas = 0;
            oranges = 0;
            cherries = 0;
            bars = 0;
            bells = 0;
            sevens = 0;
            blanks = 0;
        }

        /* Utility function to reset the player stats */
        private void resetAll()
        {
            if (MessageBox.Show("You ran out of Money! \nDo you want to play again?", "Out of Money!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                playerMoney = 1000;
                winnings = 0;
                jackpot = 5000;
                turn = 0;
                playerBet = 0;
                winNumber = 0;
                lossNumber = 0;
                winRatio = 0.0f;

                WinnerPaidTextBox.Text = "";
                ReelOnePictureBox.Image = Properties.Resources.bell;
                ReelTwoPictureBox.Image = Properties.Resources.orange;
                ReelThreePictureBox.Image = Properties.Resources.banana;

                TotalCreditsTextBox.Text = Convert.ToString(playerMoney);
                BetTextBox.Text = "0";
            }
        }

        /* Check to see if the player won the jackpot */
        private void checkJackPot()
        {
            /* compare two random values */
            var jackPotTry = this.random.Next(51) + 1;
            var jackPotWin = this.random.Next(51) + 1;
            if (jackPotTry == jackPotWin)
            {
                MessageBox.Show("You Won the $" + jackpot + " Jackpot!!", "Jackpot!!");                
                playerMoney += jackpot;
                jackpot = 5000;
                JackpotTextBox.Text = Convert.ToString(jackpot);
            }
        }

        /* Utility function to show a win message and increase player money */
        private void showWinMessage()
        {
            playerMoney += winnings;            
            WinnerPaidTextBox.Text = Convert.ToString(winnings);
            resetFruitTally();
            checkJackPot();
        }

        /* Utility function to show a loss message and reduce player money */
        private void showLossMessage()
        {
            playerMoney -= playerBet;                                              
            resetFruitTally();
        }

        /* Utility function to check if a value falls within a range of bounds */
        private bool checkRange(int value, int lowerBounds, int upperBounds)
        {
            return (value >= lowerBounds && value <= upperBounds) ? true : false;

        }

        /* When this function is called it determines the betLine results.
    e.g. Bar - Orange - Banana */
        private string[] Reels()
        {
            //An array for change images in reels
            PictureBox[] reel_spin = { ReelOnePictureBox, ReelTwoPictureBox, ReelThreePictureBox };

            string[] betLine = { " ", " ", " " };

            int[] outCome = { 0, 0, 0 };

            for (var spin = 0; spin < 3; spin++)
            {
                outCome[spin] = this.random.Next(65) + 1;

                if (checkRange(outCome[spin], 1, 27))
                {                    
                    // 41.5% probability
                    betLine[spin] = "blank";
                    reel_spin[spin].Image = Properties.Resources.blank;
                    blanks++;
                }
                else if (checkRange(outCome[spin], 28, 37))
                {                    
                    // 15.4% probability
                    betLine[spin] = "Grapes";
                    reel_spin[spin].Image = Properties.Resources.grapes;
                    grapes++;
                }
                else if (checkRange(outCome[spin], 38, 46))
                {                   
                    // 13.8% probability
                    betLine[spin] = "Banana";
                    reel_spin[spin].Image = Properties.Resources.banana;
                    bananas++;
                }
                else if (checkRange(outCome[spin], 47, 54))
                {                   
                    // 12.3% probability
                    betLine[spin] = "Orange";
                    reel_spin[spin].Image = Properties.Resources.orange;
                    oranges++;
                }
                else if (checkRange(outCome[spin], 55, 59))
                {                   
                    //  7.7% probability
                    betLine[spin] = "Cherry";
                    reel_spin[spin].Image = Properties.Resources.cherry;
                    cherries++;
                }
                else if (checkRange(outCome[spin], 60, 62))
                {                    
                    //  4.6% probability
                    betLine[spin] = "Bar";
                    reel_spin[spin].Image = Properties.Resources.bar;
                    bars++;
                }
                else if (checkRange(outCome[spin], 63, 64))
                {
                    //  3.1% probability
                    betLine[spin] = "Bell";
                    reel_spin[spin].Image = Properties.Resources.bell;
                    bells++;
                }
                else if (checkRange(outCome[spin], 65, 65))
                {                   
                    //  1.5% probability
                    betLine[spin] = "Seven";
                    reel_spin[spin].Image = Properties.Resources.seven;
                    sevens++;
                }

            }
            return betLine;
        }

        /* This function calculates the player's winnings, if any */
        private void determineWinnings()
        {
            if (blanks == 0)
            {
                if (grapes == 3)
                {
                    winnings = playerBet * 10;
                }
                else if (bananas == 3)
                {
                    winnings = playerBet * 20;
                }
                else if (oranges == 3)
                {
                    winnings = playerBet * 30;
                }
                else if (cherries == 3)
                {
                    winnings = playerBet * 40;
                }
                else if (bars == 3)
                {
                    winnings = playerBet * 50;
                }
                else if (bells == 3)
                {
                    winnings = playerBet * 75;
                }
                else if (sevens == 3)
                {
                    winnings = playerBet * 100;
                }
                else if (grapes == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (bananas == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (oranges == 2)
                {
                    winnings = playerBet * 3;
                }
                else if (cherries == 2)
                {
                    winnings = playerBet * 4;
                }
                else if (bars == 2)
                {
                    winnings = playerBet * 5;
                }
                else if (bells == 2)
                {
                    winnings = playerBet * 10;
                }
                else if (sevens == 2)
                {
                    winnings = playerBet * 20;
                }
                else if (sevens == 1)
                {
                    winnings = playerBet * 5;
                }
                else
                {
                    winnings = playerBet * 1;
                }
                winNumber++;
                showWinMessage();
            }
            else
            {
                lossNumber++;
                showLossMessage();
            }

        }
        /// <summary>
        /// This is handler for Spin Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpinPictureBox_Click(object sender, EventArgs e)
        {
            //playerBet = 0;
            //WinnerPaidTextBox.Text = Convert.ToString(winnings);
            //playerBet = Convert.ToInt32(BetTextBox.Text);
            JackpotTextBox.Text = "";
                                 
            if (playerMoney == 0)
            {
                if (MessageBox.Show("You ran out of Money! \nDo you want to play again?", "Out of Money!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resetAll();
                    showPlayerStats();
                }
            }
            else if (playerBet > playerMoney)
            {
                MessageBox.Show("You don't have enough Money to place that bet.", "Insufficient Funds");
            }
            else if (playerBet < 0)
            {
                MessageBox.Show("All bets must be a positive $ amount.", "Incorrect Bet");
            }
            else if (playerBet <= playerMoney)
            {
                spinResult = Reels();
                TotalCreditsTextBox.Text = Convert.ToString(playerMoney);                
                determineWinnings();
                TotalCreditsTextBox.Text = Convert.ToString(playerMoney);
                turn++;


                if (playerMoney <= 0)
                {
                    if (MessageBox.Show("You ran out of Money! \nDo you want to play again?", "Out of Money!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        resetAll();                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid bet amount");
            }
        }
       
        /// <summary>
        /// This is handler for Power Button to Terminate Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PowerButtonPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure you wants to quit the game?", "Exit", MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                MessageBox.Show("Thank you for Playing with Slot Machine..!!!");
                Application.Exit();
            }            
            else
            {
                //It will not allow user to QUIT from the Game
            }
        }
        /// <summary>
        /// This is handler for Slot Machine Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>                      
        private void SlotMachineForm_Load(object sender, EventArgs e)
        {
            TotalCreditsTextBox.Text = Convert.ToString(playerMoney);
            BetTextBox.Text = "0";
            WinnerPaidTextBox.Text = "0";
            
            // Displays Different Images in appropriate PictureBoxes
            ReelOnePictureBox.Image = Properties.Resources.bell;
            ReelTwoPictureBox.Image = Properties.Resources.orange;
            ReelThreePictureBox.Image = Properties.Resources.banana;

        }

        /// <summary>
        /// This is handler for reset all credit click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetPictureBox_Click(object sender, EventArgs e)
        {
            resetAll();
        }
    }

}
