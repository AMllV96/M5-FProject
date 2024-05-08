namespace TravelAgencyFP
{
    partial class Form3
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
            LogInButton = new Button();
            passTextBox = new TextBox();
            usernameTextBox = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.LightSteelBlue;
            LogInButton.FlatStyle = FlatStyle.Popup;
            LogInButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LogInButton.ForeColor = Color.SteelBlue;
            LogInButton.Location = new Point(374, 332);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(75, 36);
            LogInButton.TabIndex = 7;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // passTextBox
            // 
            passTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passTextBox.ForeColor = Color.SteelBlue;
            passTextBox.Location = new Point(354, 249);
            passTextBox.Name = "passTextBox";
            passTextBox.PlaceholderText = "password";
            passTextBox.Size = new Size(116, 23);
            passTextBox.TabIndex = 5;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.ForeColor = Color.SteelBlue;
            usernameTextBox.Location = new Point(354, 201);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "username";
            usernameTextBox.Size = new Size(116, 23);
            usernameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(354, 100);
            label1.Name = "label1";
            label1.Size = new Size(120, 42);
            label1.TabIndex = 8;
            label1.Text = "Log In";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Location = new Point(257, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 342);
            panel2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Location = new Point(563, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 342);
            panel1.TabIndex = 10;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(LogInButton);
            Controls.Add(passTextBox);
            Controls.Add(usernameTextBox);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogInButton;
        private TextBox passTextBox;
        private TextBox usernameTextBox;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
    }
}