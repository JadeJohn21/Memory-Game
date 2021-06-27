using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class DifficultQuestionsForm : Form
    {
        public DifficultQuestionsForm()
        {
            InitializeComponent();
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            DifficultQuestionsForm difficultQuestionsForm = new DifficultQuestionsForm();
            difficultQuestionsForm.Close();                     //Close this form.
            GameLevels gameLevels = new GameLevels();
            gameLevels.Show();                                  // Open the previous one.
        }
    }
}
