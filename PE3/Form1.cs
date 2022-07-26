using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE3
{
    public partial class GuessingGameForm : Form

    {
        private Random ranValue;
        private int chosenNum;
        private int numGuess;

        public GuessingGameForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ranValue = new Random();
            chosenNum = ranValue.Next(0, 101);
            numGuess = 1;
            lblCount.Text = "0";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int userGuess = Convert.ToInt32(txtBxGuess.Text);
            if (userGuess > chosenNum)
            {
                lblMessage.Text = "Your guess is too high!";
                lblCount.Text = Convert.ToString(numGuess++);
                BackColor = Color.DarkCyan;
                
            }
            if (userGuess < chosenNum)
            {
                lblMessage.Text = "Your number is too low!";
                lblCount.Text = Convert.ToString(numGuess++);
                BackColor = Color.Crimson;
            }
            if (userGuess == chosenNum)
            {
                lblMessage.Text = "You got it! You won!";
                lblCount.Text = Convert.ToString(numGuess++);
                BackColor = Color.Green;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCount.Text = "0";
            lblMessage.Text = "";
            txtBxGuess.Text = "";
            numGuess = 1;
            BackColor = Color.MediumOrchid;
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }
    }
}
