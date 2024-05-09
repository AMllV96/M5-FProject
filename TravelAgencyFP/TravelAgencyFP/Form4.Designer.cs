namespace TravelAgencyFP
{
    partial class Form4
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
            pictureBox1 = new PictureBox();
            saveButton = new Button();
            genderGB = new GroupBox();
            maleRB = new RadioButton();
            femaleRB = new RadioButton();
            countryTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            browseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            genderGB.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(75, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 179);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(94, 316);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // genderGB
            // 
            genderGB.Controls.Add(maleRB);
            genderGB.Controls.Add(femaleRB);
            genderGB.Location = new Point(366, 272);
            genderGB.Margin = new Padding(2);
            genderGB.Name = "genderGB";
            genderGB.Padding = new Padding(2);
            genderGB.Size = new Size(210, 90);
            genderGB.TabIndex = 12;
            genderGB.TabStop = false;
            genderGB.Text = "gender";
            genderGB.Enter += genderGB_Enter;
            // 
            // maleRB
            // 
            maleRB.AutoSize = true;
            maleRB.Location = new Point(13, 28);
            maleRB.Margin = new Padding(2);
            maleRB.Name = "maleRB";
            maleRB.Size = new Size(51, 19);
            maleRB.TabIndex = 5;
            maleRB.TabStop = true;
            maleRB.Text = "male";
            maleRB.UseVisualStyleBackColor = true;
            // 
            // femaleRB
            // 
            femaleRB.AutoSize = true;
            femaleRB.Location = new Point(119, 28);
            femaleRB.Margin = new Padding(2);
            femaleRB.Name = "femaleRB";
            femaleRB.Size = new Size(61, 19);
            femaleRB.TabIndex = 7;
            femaleRB.TabStop = true;
            femaleRB.Text = "female";
            femaleRB.UseVisualStyleBackColor = true;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(424, 171);
            countryTextBox.Margin = new Padding(2);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.PlaceholderText = "Country";
            countryTextBox.Size = new Size(106, 23);
            countryTextBox.TabIndex = 11;
            countryTextBox.TextChanged += countryTextBox_TextChanged;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(422, 126);
            LastNameTextBox.Margin = new Padding(2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.PlaceholderText = "Last name";
            LastNameTextBox.Size = new Size(106, 23);
            LastNameTextBox.TabIndex = 10;
            LastNameTextBox.TextChanged += LastNameTextBox_TextChanged;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(422, 77);
            firstNameTextBox.Margin = new Padding(2);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "First name";
            firstNameTextBox.Size = new Size(106, 23);
            firstNameTextBox.TabIndex = 9;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(94, 250);
            browseButton.Margin = new Padding(2);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(78, 20);
            browseButton.TabIndex = 13;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(browseButton);
            Controls.Add(genderGB);
            Controls.Add(countryTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(saveButton);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            genderGB.ResumeLayout(false);
            genderGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button saveButton;
        private GroupBox genderGB;
        private RadioButton maleRB;
        private RadioButton femaleRB;
        private TextBox countryTextBox;
        private TextBox LastNameTextBox;
        private TextBox firstNameTextBox;
        private Button browseButton;
    }
}