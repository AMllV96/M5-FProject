namespace TravelAgencyFP
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            usernameTextBox = new TextBox();
            passTextBox = new TextBox();
            confirmPassTextBox = new TextBox();
            signUpButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            usernameError = new ErrorProvider(components);
            passwordCheck = new ErrorProvider(components);
            passwordCheckConfirm = new ErrorProvider(components);
            passwordErrorLabel = new Label();
            passwordMatchError = new Label();
            UsernameErrorLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usernameError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordCheckConfirm).BeginInit();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.Azure;
            usernameTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.ForeColor = Color.SteelBlue;
            usernameTextBox.Location = new Point(336, 94);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "username";
            usernameTextBox.Size = new Size(116, 23);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passTextBox
            // 
            passTextBox.BackColor = Color.Azure;
            passTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passTextBox.ForeColor = Color.SteelBlue;
            passTextBox.Location = new Point(336, 150);
            passTextBox.Name = "passTextBox";
            passTextBox.PlaceholderText = "password";
            passTextBox.Size = new Size(116, 23);
            passTextBox.TabIndex = 1;
            // 
            // confirmPassTextBox
            // 
            confirmPassTextBox.BackColor = Color.Azure;
            confirmPassTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPassTextBox.ForeColor = Color.SteelBlue;
            confirmPassTextBox.Location = new Point(336, 206);
            confirmPassTextBox.Name = "confirmPassTextBox";
            confirmPassTextBox.PlaceholderText = "confirm password";
            confirmPassTextBox.Size = new Size(116, 23);
            confirmPassTextBox.TabIndex = 2;
            confirmPassTextBox.TextChanged += confirmPassTextBox_TextChanged;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.LightSteelBlue;
            signUpButton.FlatStyle = FlatStyle.Popup;
            signUpButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            signUpButton.ForeColor = Color.SteelBlue;
            signUpButton.Location = new Point(357, 263);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(86, 40);
            signUpButton.TabIndex = 3;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(238, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 342);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 327);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Location = new Point(541, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(14, 331);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(336, 19);
            label1.Name = "label1";
            label1.Size = new Size(122, 36);
            label1.TabIndex = 7;
            label1.Text = "Sign Up";
            label1.Click += label1_Click;
            // 
            // usernameError
            // 
            usernameError.ContainerControl = this;
            // 
            // passwordCheck
            // 
            passwordCheck.ContainerControl = this;
            // 
            // passwordCheckConfirm
            // 
            passwordCheckConfirm.ContainerControl = this;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordErrorLabel.ForeColor = Color.Firebrick;
            passwordErrorLabel.Location = new Point(0, 379);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(800, 21);
            passwordErrorLabel.TabIndex = 8;
            passwordErrorLabel.Text = "Password should contain 8 symbols, at least one special symbol, capital letter, small letter and at least a single digit";
            passwordErrorLabel.Visible = false;
            passwordErrorLabel.Click += passwordErrorLabel_Click;
            // 
            // passwordMatchError
            // 
            passwordMatchError.AutoSize = true;
            passwordMatchError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordMatchError.ForeColor = Color.Firebrick;
            passwordMatchError.Location = new Point(179, 420);
            passwordMatchError.Name = "passwordMatchError";
            passwordMatchError.Size = new Size(376, 21);
            passwordMatchError.TabIndex = 9;
            passwordMatchError.Text = "The confirmed password should match the intial one.";
            passwordMatchError.Visible = false;
            passwordMatchError.Click += passwordMatchError_Click;
            // 
            // UsernameErrorLabel
            // 
            UsernameErrorLabel.AutoSize = true;
            UsernameErrorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameErrorLabel.ForeColor = Color.Firebrick;
            UsernameErrorLabel.Location = new Point(156, 345);
            UsernameErrorLabel.Name = "UsernameErrorLabel";
            UsernameErrorLabel.Size = new Size(492, 21);
            UsernameErrorLabel.TabIndex = 10;
            UsernameErrorLabel.Text = "Username should be in the form of a email (contain @ and a domain).";
            UsernameErrorLabel.Visible = false;
            UsernameErrorLabel.Click += UsernameErrorLabel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(UsernameErrorLabel);
            Controls.Add(passwordMatchError);
            Controls.Add(passwordErrorLabel);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(signUpButton);
            Controls.Add(confirmPassTextBox);
            Controls.Add(passTextBox);
            Controls.Add(usernameTextBox);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usernameError).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordCheckConfirm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passTextBox;
        private TextBox confirmPassTextBox;
        private Button signUpButton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private ErrorProvider usernameError;
        private ErrorProvider passwordCheck;
        private ErrorProvider passwordCheckConfirm;
        private Label passwordMatchError;
        private Label passwordErrorLabel;
        private Label UsernameErrorLabel;
    }
}