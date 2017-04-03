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
            ((System.ComponentModel.ISupportInitialize)(this.SpinButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelOnePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelTwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelThreePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinButtonPictureBox
            // 
            this.SpinButtonPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SpinButtonPictureBox.Image = global::SlotMachine_Assignment5.Properties.Resources.spin;
            this.SpinButtonPictureBox.Location = new System.Drawing.Point(199, 443);
            this.SpinButtonPictureBox.Name = "SpinButtonPictureBox";
            this.SpinButtonPictureBox.Size = new System.Drawing.Size(60, 50);
            this.SpinButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinButtonPictureBox.TabIndex = 6;
            this.SpinButtonPictureBox.TabStop = false;
            this.SpinButtonPictureBox.Click += new System.EventHandler(this.SpinPictureBox_Click);
            // 
            // ReelOnePictureBox
            // 
            this.ReelOnePictureBox.Location = new System.Drawing.Point(77, 240);
            this.ReelOnePictureBox.Name = "ReelOnePictureBox";
            this.ReelOnePictureBox.Size = new System.Drawing.Size(81, 100);
            this.ReelOnePictureBox.TabIndex = 7;
            this.ReelOnePictureBox.TabStop = false;
            // 
            // ReelTwoPictureBox
            // 
            this.ReelTwoPictureBox.Location = new System.Drawing.Point(189, 240);
            this.ReelTwoPictureBox.Name = "ReelTwoPictureBox";
            this.ReelTwoPictureBox.Size = new System.Drawing.Size(81, 100);
            this.ReelTwoPictureBox.TabIndex = 7;
            this.ReelTwoPictureBox.TabStop = false;
            // 
            // ReelThreePictureBox
            // 
            this.ReelThreePictureBox.Location = new System.Drawing.Point(302, 240);
            this.ReelThreePictureBox.Name = "ReelThreePictureBox";
            this.ReelThreePictureBox.Size = new System.Drawing.Size(81, 100);
            this.ReelThreePictureBox.TabIndex = 7;
            this.ReelThreePictureBox.TabStop = false;
            // 
            // PowerButtonPictureBox
            // 
            this.PowerButtonPictureBox.Image = global::SlotMachine_Assignment5.Properties.Resources.powerbutton;
            this.PowerButtonPictureBox.Location = new System.Drawing.Point(284, 443);
            this.PowerButtonPictureBox.Name = "PowerButtonPictureBox";
            this.PowerButtonPictureBox.Size = new System.Drawing.Size(60, 50);
            this.PowerButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PowerButtonPictureBox.TabIndex = 8;
            this.PowerButtonPictureBox.TabStop = false;
            this.PowerButtonPictureBox.Click += new System.EventHandler(this.PowerButtonPictureBox_Click);
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::SlotMachine_Assignment5.Properties.Resources.slotmachine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(462, 533);
            this.ControlBox = false;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinButtonPictureBox;
        private System.Windows.Forms.PictureBox ReelOnePictureBox;
        private System.Windows.Forms.PictureBox ReelTwoPictureBox;
        private System.Windows.Forms.PictureBox ReelThreePictureBox;
        private System.Windows.Forms.PictureBox PowerButtonPictureBox;
    }
}