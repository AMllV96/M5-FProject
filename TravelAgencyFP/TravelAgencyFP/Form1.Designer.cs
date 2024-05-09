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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SignUpButton = new Button();
            logInButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.FromArgb(152, 60, 87);
            SignUpButton.FlatStyle = FlatStyle.Popup;
            SignUpButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpButton.ForeColor = Color.LavenderBlush;
            SignUpButton.Location = new Point(387, 586);
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
            logInButton.BackColor = Color.FromArgb(152, 60, 87);
            logInButton.FlatStyle = FlatStyle.Popup;
            logInButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            logInButton.ForeColor = Color.MistyRose;
            logInButton.Location = new Point(624, 586);
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
            label1.Location = new Point(293, 357);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(2, 66);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(215, 71);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(692, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(logInButton);
            panel1.Controls.Add(SignUpButton);
            panel1.Location = new Point(14, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 722);
            panel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(152, 60, 87);
            ClientSize = new Size(1143, 750);
            Controls.Add(panel1);
            ForeColor = Color.MistyRose;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button SignUpButton;
        private Button logInButton;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}