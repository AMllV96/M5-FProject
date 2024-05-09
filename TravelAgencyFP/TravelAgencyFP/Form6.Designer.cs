namespace TravelAgencyFP
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            UserProfileButton = new Button();
            townTextBox = new TextBox();
            townLabel = new Label();
            idTextBox = new TextBox();
            DeleteButton = new Button();
            UpdateButton = new Button();
            AddButton = new Button();
            IDLabel = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserProfileButton
            // 
            UserProfileButton.Location = new Point(471, 487);
            UserProfileButton.Name = "UserProfileButton";
            UserProfileButton.Size = new Size(111, 33);
            UserProfileButton.TabIndex = 22;
            UserProfileButton.Text = "User Profile";
            UserProfileButton.UseVisualStyleBackColor = true;
            // 
            // townTextBox
            // 
            townTextBox.Location = new Point(380, 385);
            townTextBox.Name = "townTextBox";
            townTextBox.Size = new Size(150, 31);
            townTextBox.TabIndex = 21;
            // 
            // townLabel
            // 
            townLabel.AutoSize = true;
            townLabel.Location = new Point(229, 356);
            townLabel.Name = "townLabel";
            townLabel.Size = new Size(111, 25);
            townLabel.TabIndex = 20;
            townLabel.Text = "Destination: ";
            townLabel.Click += townLabel_Click;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(379, 232);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(150, 31);
            idTextBox.TabIndex = 19;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(725, 487);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(134, 33);
            DeleteButton.TabIndex = 18;
            DeleteButton.Text = "Delete Town";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(462, 422);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(137, 33);
            UpdateButton.TabIndex = 17;
            UpdateButton.Text = "Update Town";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Popup;
            AddButton.Location = new Point(263, 412);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(111, 33);
            AddButton.TabIndex = 16;
            AddButton.Text = "Add Town";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(229, 250);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(31, 25);
            IDLabel.TabIndex = 15;
            IDLabel.Text = "id:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 198, 204);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(UserProfileButton);
            panel1.Controls.Add(townTextBox);
            panel1.Controls.Add(townLabel);
            panel1.Controls.Add(idTextBox);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(IDLabel);
            panel1.Location = new Point(31, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 695);
            panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 561);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1143, 750);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button UserProfileButton;
        private TextBox townTextBox;
        private Label townLabel;
        private TextBox idTextBox;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button AddButton;
        private Label IDLabel;
        private Panel panel1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}