using System;
using System.Drawing;


/*Apologies for the jumbled mess. I got lost in my own code and couldn't seem to work myself out out of the corner I painted myself into.
 */ 



namespace Craps
{
    public partial class frm_Main : Form
    {
        
        // creates random number generator object
        private Random randomNumber = new Random();

        // uses enum to define user game status
        private enum Status {WIN, LOSE, CONTINUE}
        
        private enum rollNames
        {
            SNAKE_EYES = 2, TREY = 3, SEVEN = 7, YO = 11,MIDNIGHT = 12,
        } // end rollNames


        public frm_Main()
        {
            InitializeComponent();
        } // end frmMain empty-arg

        private void frm_Main_Load(object sender, EventArgs e)
        {

        } // end frmMain preferred arg

        private void lbl_Die1_Click(object sender, EventArgs e)
        {
          
        } // end lblDie1

        private void lblDie2_Click(object sender, EventArgs e)
        {

        } // end lblDie2

        private void txtBet_TextChanged(object sender, EventArgs e)
        {
          
            } // end txtBet

        public void calculateBalance()
        {
        
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            calculate_score();
        } // end btnRoll

        private void lblPoints_Click(object sender, EventArgs e)
        {

        } // end lblPoints

        public void calculate_score()
        {
            Status gameStatus = Status.CONTINUE;
            int bet = 0;
            int balance = 100;
            int win = 10;
            int point = 0;


   
            int die1 = randomNumber.Next(1, 7); // generates random number for first die
            lblDie1.Text = die1.ToString();

            int die2 = randomNumber.Next(1, 7); // generates random number for second die
            lblDie2.Text = die2.ToString();

            int sum = die1 + die2; // sum of both dice
            
            switch ((rollNames)sum)
            {
                // first roll WINS
                case rollNames.SEVEN: // 7 is a WIN
                case rollNames.YO: // 11 is a WIN
                    gameStatus = Status.WIN; // changes Status to WON
                    int newBalance = balance + 10;
                    lblResult.Text = "You win!";
                    lblBalance.Text = newBalance.ToString();

                    break; // case end

                // first roll LOSSES
                case rollNames.SNAKE_EYES: // 2 (1 & 1) is a LOSS
                case rollNames.TREY: // 3 is a LOSS
                case rollNames.MIDNIGHT: // 12 is a LOSS
                    gameStatus = Status.LOSE; // changes Status to LOST
                    int loss = balance - bet;
                    lblResult.Text = "You lose!";
                    int newBalance = balance - bet;
                    lblBalance.Text = newBalance.ToString();
                    break; // case end


                default: // continue roll if no win or lose on first roll
                    gameStatus = Status.CONTINUE; // default status to allow dice to keep rolling
                    point = sum; // running tally sum of rolls
                    break; // end default
            } // end switch

            lblPoints.Text = sum.ToString("Point is: "+sum); // prints results of the roll

            while (gameStatus == Status.CONTINUE) // keeps rolling dice
            {
                calculate_score(); // calls calculate_score method to roll dice again

                if (sum == point)
                    gameStatus = Status.WIN; // changes status to WON if you make your point

                else if (sum == (int)rollNames.SEVEN)
                    gameStatus = Status.LOSE;  // changes status to LOST if you roll 7 before making your point
            } // end while

        } // end calculate_score

        private void lblBalance_Click(object sender, EventArgs e)
        {
           
        }

        private void lblYouWin_Click(object sender, EventArgs e)
        {
          
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
         
        }
    } // end class

} // end namespace