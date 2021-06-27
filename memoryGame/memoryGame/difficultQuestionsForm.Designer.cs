
namespace memoryGame
{
    partial class DifficultQuestionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftArrow
            // 
            this.LeftArrow.Image = global::memoryGame.Properties.Resources.arrow_left_circle_318_1450_removebg_preview;
            this.LeftArrow.Location = new System.Drawing.Point(12, 12);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(48, 44);
            this.LeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftArrow.TabIndex = 14;
            this.LeftArrow.TabStop = false;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // DifficultQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(859, 550);
            this.Controls.Add(this.LeftArrow);
            this.Name = "DifficultQuestionsForm";
            this.Text = "difficultQuestionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LeftArrow;
    }
}