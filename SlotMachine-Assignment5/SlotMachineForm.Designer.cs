namespace SlotMachine_Assignment5
{
    partial class SlotMachineForm
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
            this.SpinButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.ReelOnePictureBox = new System.Windows.Forms.PictureBox();
            this.ReelTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.ReelThreePictureBox = new System.Windows.Forms.PictureBox();
            this.PowerButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.JackpotTextBox = new System.Windows.Forms.TextBox();
            this.TotalCreditsTextBox = new System.Windows.Forms.TextBox();
            this.BetTextBox = new System.Windows.Forms.TextBox();
            this.WinnerPaidTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpinButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelOnePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelTwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelThreePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinButtonPictureBox
            // 
            this.SpinButtonPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SpinButtonPictureBox.Image = global::SlotMachine_Assignment5.Properties.Resources.spin;
            this.SpinButtonPictureBox.Location = new System.Drawing.Point(344, 434);
            this.SpinButtonPictureBox.Name = "SpinButtonPictureBox";
            this.SpinButtonPictureBox.Size = new System.Drawing.Size(52, 50);
            this.SpinButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinButtonPictureBox.TabIndex = 6;
            this.SpinButtonPictureBox.TabStop = false;
            this.SpinButtonPictureBox.Click += new System.EventHandler(this.SpinPictureBox_Click);
            // 
            // ReelOnePictureBox
            // 
            this.ReelOnePictureBox.Image = global::SlotMachine_Assignment5.Properties.Resources.bell;
            this.ReelOnePictureBox.Location = new System.Drawing.Point(72, 221);
            this.ReelOnePictureBox.Name = "ReelOnePictureBox";
            this.ReelOnePictureBox.Size = new System.Drawing.Size(84, 127);
            this.ReelOnePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReelOnePictureBox.TabIndex = 7;
            this.ReelOnePictureBox.TabStop = false;
            // 
            // ReelTwoPictureBox
            // 
            this.ReelTwoPictureBox.Image = global::SlotMachine_Assignment5.Properties.Resources.orange;
            this.ReelTwoPictureBox.Location = new System.Drawing.Point(179, 221);
            this.ReelTwoPictureBox.Name = "ReelTwoPictureBox";
            this.ReelTwoPictureBox.Size = new System.Drawing.Size(90, 127);
            this.ReelTwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReelTwoPictureBox.TabIndex = 7;
            this.ReelTwoPictureBox.TabStop = false;
            // 
            // ReelThreePictureBox
            // 
            this.ReelThreePictureBox.Image = global::SlotMachine_Assignment5.Properties.Resources.banana;
            this.ReelThreePictureBox.Location = new System.Drawing.Point(290, 221);
            this.ReelThreePictureBox.Name = "ReelThreePictureBox";
            this.ReelThreePictureBox.Size = new System.Drawing.Size(91, 127);
            this.ReelThreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReelThreePictureBox.TabIndex = 7;
            this.ReelThreePictureBox.TabStop = false;
            // 
            // PowerButtonPictureBox
            // 
            this.PowerButtonPictureBox.Image = global::SlotMachine_Assignment5.Properties.Resources.powerbutton;
            this.PowerButtonPictureBox.Location = new System.Drawing.Point(64, 434);
            this.PowerButtonPictureBox.Name = "PowerButtonPictureBox";
            this.PowerButtonPictureBox.Size = new System.Drawing.Size(51, 50);
            this.PowerButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PowerButtonPictureBox.TabIndex = 8;
            this.PowerButtonPictureBox.TabStop = false;
            this.PowerButtonPictureBox.Click += new System.EventHandler(this.PowerButtonPictureBox_Click);
            // 
            // JackpotTextBox
            // 
            this.JackpotTextBox.BackColor = System.Drawing.Color.Gray;
            this.JackpotTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JackpotTextBox.ForeColor = System.Drawing.Color.Red;
            this.JackpotTextBox.Location = new System.Drawing.Point(175, 156);
            this.JackpotTextBox.Name = "JackpotTextBox";
            this.JackpotTextBox.ReadOnly = true;
            this.JackpotTextBox.Size = new System.Drawing.Size(104, 27);
            this.JackpotTextBox.TabIndex = 9;
            // 
            // TotalCreditsTextBox
            // 
            this.TotalCreditsTextBox.BackColor = System.Drawing.Color.Gray;
            this.TotalCreditsTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCreditsTextBox.Location = new System.Drawing.Point(70, 364);
            this.TotalCreditsTextBox.Name = "TotalCreditsTextBox";
            this.TotalCreditsTextBox.ReadOnly = true;
            this.TotalCreditsTextBox.Size = new System.Drawing.Size(100, 27);
            this.TotalCreditsTextBox.TabIndex = 10;
            // 
            // BetTextBox
            // 
            this.BetTextBox.BackColor = System.Drawing.Color.Gray;
            this.BetTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetTextBox.Location = new System.Drawing.Point(193, 364);
            this.BetTextBox.Name = "BetTextBox";
            this.BetTextBox.ReadOnly = true;
            this.BetTextBox.Size = new System.Drawing.Size(60, 27);
            this.BetTextBox.TabIndex = 10;
            // 
            // WinnerPaidTextBox
            // 
            this.WinnerPaidTextBox.BackColor = System.Drawing.Color.Gray;
            this.WinnerPaidTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerPaidTextBox.Location = new System.Drawing.Point(279, 364);
            this.WinnerPaidTextBox.Name = "WinnerPaidTextBox";
            this.WinnerPaidTextBox.ReadOnly = true;
            this.WinnerPaidTextBox.Size = new System.Drawing.Size(100, 27);
            this.WinnerPaidTextBox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SlotMachine_Assignment5.Properties.Resources.reset;
            this.pictureBox1.Location = new System.Drawing.Point(123, 434);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SlotMachine_Assignment5.Properties.Resources.bet25;
            this.pictureBox2.Location = new System.Drawing.Point(183, 434);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 50);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SlotMachine_Assignment5.Properties.Resources.bet50;
            this.pictureBox3.Location = new System.Drawing.Point(237, 434);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 50);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SlotMachine_Assignment5.Properties.Resources.bet100;
            this.pictureBox4.Location = new System.Drawing.Point(290, 434);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::SlotMachine_Assignment5.Properties.Resources.slotmachine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(450, 521);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WinnerPaidTextBox);
            this.Controls.Add(this.BetTextBox);
            this.Controls.Add(this.TotalCreditsTextBox);
            this.Controls.Add(this.JackpotTextBox);
            this.Controls.Add(this.PowerButtonPictureBox);
            this.Controls.Add(this.ReelThreePictureBox);
            this.Controls.Add(this.ReelTwoPictureBox);
            this.Controls.Add(this.ReelOnePictureBox);
            this.Controls.Add(this.SpinButtonPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SlotMachineForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.SpinButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelOnePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelTwoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelThreePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinButtonPictureBox;
        private System.Windows.Forms.PictureBox ReelOnePictureBox;
        private System.Windows.Forms.PictureBox ReelTwoPictureBox;
        private System.Windows.Forms.PictureBox ReelThreePictureBox;
        private System.Windows.Forms.PictureBox PowerButtonPictureBox;
        private System.Windows.Forms.TextBox JackpotTextBox;
        private System.Windows.Forms.TextBox TotalCreditsTextBox;
        private System.Windows.Forms.TextBox BetTextBox;
        private System.Windows.Forms.TextBox WinnerPaidTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}