namespace TravelAgencyFP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SignUpButton = new Button();
            logInButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.FromArgb(255, 192, 192);
            SignUpButton.FlatStyle = FlatStyle.Popup;
            SignUpButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpButton.ForeColor = Color.FromArgb(128, 64, 64);
            SignUpButton.Location = new Point(436, 502);
            SignUpButton.Margin = new Padding(4, 5, 4, 5);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(107, 62);
            SignUpButton.TabIndex = 0;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // logInButton
            // 
            logInButton.BackColor = Color.FromArgb(255, 192, 192);
            logInButton.FlatStyle = FlatStyle.Popup;
            logInButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            logInButton.ForeColor = Color.FromArgb(128, 64, 64);
            logInButton.Location = new Point(611, 502);
            logInButton.Margin = new Padding(4, 5, 4, 5);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(107, 62);
            logInButton.TabIndex = 1;
            logInButton.Text = "Log In";
            logInButton.UseVisualStyleBackColor = false;
            logInButton.Click += logInButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft YaHei", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(307, 372);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(564, 66);
            label1.TabIndex = 2;
            label1.Text = "Travel Agency \"STAV\"";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.travel;
            pictureBox1.Location = new Point(436, 113);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1143, 750);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(logInButton);
            Controls.Add(SignUpButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignUpButton;
        private Button logInButton;
        private Label label1;
        private PictureBox pictureBox1;
    }
}