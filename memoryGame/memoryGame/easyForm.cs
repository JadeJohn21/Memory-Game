using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class EasyForm : Form
    {
        private HomePage homePage;
        private GameLevels gameLevels;
        private EasyForm easyForm;
        private int countDown;
        public EasyForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CountDown_TextChanged(object sender, EventArgs e)
        {
            if (countDown > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                countDown = countDown - 1;
                CountDownControl.Text = countDown + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                countDownTimer.Stop();
                CountDownControl.Text = "Time's up!";
            }
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            EasyForm easyForm = new EasyForm();
            easyForm.Close();                                 //Close this form.
            GameLevels gameLevels = new GameLevels();
            gameLevels.Show();                                    //Open a new one.
        }
    }
}
