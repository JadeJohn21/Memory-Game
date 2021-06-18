
namespace memoryGame
{
    partial class EasyForm
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
            this.components = new System.ComponentModel.Container();
            this.helloImage = new System.Windows.Forms.PictureBox();
            this.englishLabel = new System.Windows.Forms.Label();
            this.afrikaansLabel = new System.Windows.Forms.Label();
            this.helloLabel = new System.Windows.Forms.Label();
            this.helLabel = new System.Windows.Forms.Label();
            this.CountDownControl = new System.Windows.Forms.TextBox();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Label();
            this.LeftArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.helloImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // helloImage
            // 
            this.helloImage.Image = global::memoryGame.Properties.Resources.hello;
            this.helloImage.Location = new System.Drawing.Point(236, 41);
            this.helloImage.Name = "helloImage";
            this.helloImage.Size = new System.Drawing.Size(368, 245);
            this.helloImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helloImage.TabIndex = 1;
            this.helloImage.TabStop = false;
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.englishLabel.Location = new System.Drawing.Point(277, 315);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(73, 21);
            this.englishLabel.TabIndex = 2;
            this.englishLabel.Text = "English";
            // 
            // afrikaansLabel
            // 
            this.afrikaansLabel.AutoSize = true;
            this.afrikaansLabel.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.afrikaansLabel.Location = new System.Drawing.Point(468, 315);
            this.afrikaansLabel.Name = "afrikaansLabel";
            this.afrikaansLabel.Size = new System.Drawing.Size(94, 21);
            this.afrikaansLabel.TabIndex = 3;
            this.afrikaansLabel.Text = "Afrikaans";
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.helloLabel.Location = new System.Drawing.Point(289, 360);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(43, 20);
            this.helloLabel.TabIndex = 4;
            this.helloLabel.Text = "Hello";
            // 
            // helLabel
            // 
            this.helLabel.AutoSize = true;
            this.helLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.helLabel.Location = new System.Drawing.Point(495, 360);
            this.helLabel.Name = "helLabel";
            this.helLabel.Size = new System.Drawing.Size(31, 20);
            this.helLabel.TabIndex = 5;
            this.helLabel.Text = "Hel";
            // 
            // CountDownControl
            // 
            this.CountDownControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.CountDownControl.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountDownControl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CountDownControl.Location = new System.Drawing.Point(680, 60);
            this.CountDownControl.Name = "CountDownControl";
            this.CountDownControl.Size = new System.Drawing.Size(150, 43);
            this.CountDownControl.TabIndex = 6;
            this.CountDownControl.Text = "00:00:00";
            this.CountDownControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountDownControl.TextChanged += new System.EventHandler(this.CountDown_TextChanged);
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(710, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "You have: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(676, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seconds to memorize";
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackButton.Location = new System.Drawing.Point(12, 59);
            this.BackButton.Name = "BackButton";
            this.BackButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BackButton.Size = new System.Drawing.Size(41, 16);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            // 
            // LeftArrow
            // 
            this.LeftArrow.Image = global::memoryGame.Properties.Resources.arrow_left_circle_318_1450_removebg_preview;
            this.LeftArrow.Location = new System.Drawing.Point(12, 12);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(48, 44);
            this.LeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftArrow.TabIndex = 9;
            this.LeftArrow.TabStop = false;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // EasyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(37)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(859, 550);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountDownControl);
            this.Controls.Add(this.helLabel);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.afrikaansLabel);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.helloImage);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "EasyForm";
            this.Text = "easyForm";
            ((System.ComponentModel.ISupportInitialize)(this.helloImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox helloImage;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Label afrikaansLabel;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label helLabel;
        private System.Windows.Forms.TextBox CountDownControl;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BackButton;
        private System.Windows.Forms.PictureBox LeftArrow;
    }
}