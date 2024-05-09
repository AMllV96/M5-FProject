namespace TravelAgencyFP
{
    partial class Form5
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
            dataGridView1 = new DataGridView();
            columnsComboBox = new ComboBox();
            filterTextBox = new TextBox();
            andButton = new Button();
            orButton = new Button();
            clearButton = new Button();
            filterButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(128, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(712, 150);
            dataGridView1.TabIndex = 1;
            // 
            // columnsComboBox
            // 
            columnsComboBox.BackColor = Color.MistyRose;
            columnsComboBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            columnsComboBox.ForeColor = Color.FromArgb(128, 64, 64);
            columnsComboBox.FormattingEnabled = true;
            columnsComboBox.Location = new Point(167, 106);
            columnsComboBox.Name = "columnsComboBox";
            columnsComboBox.Size = new Size(121, 25);
            columnsComboBox.TabIndex = 2;
            columnsComboBox.SelectedIndexChanged += columnsComboBox_SelectedIndexChanged;
            // 
            // filterTextBox
            // 
            filterTextBox.BackColor = Color.MistyRose;
            filterTextBox.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            filterTextBox.ForeColor = Color.FromArgb(128, 64, 64);
            filterTextBox.Location = new Point(558, 106);
            filterTextBox.Name = "filterTextBox";
            filterTextBox.PlaceholderText = "Filter";
            filterTextBox.Size = new Size(100, 23);
            filterTextBox.TabIndex = 3;
            filterTextBox.TextChanged += filterTextBox_TextChanged;
            // 
            // andButton
            // 
            andButton.BackColor = Color.FromArgb(255, 192, 192);
            andButton.Enabled = false;
            andButton.FlatStyle = FlatStyle.Popup;
            andButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            andButton.ForeColor = Color.FromArgb(128, 64, 64);
            andButton.Location = new Point(279, 366);
            andButton.Name = "andButton";
            andButton.Size = new Size(75, 23);
            andButton.TabIndex = 4;
            andButton.Text = "AND";
            andButton.UseVisualStyleBackColor = false;
            andButton.Click += andButton_Click;
            // 
            // orButton
            // 
            orButton.BackColor = Color.FromArgb(255, 192, 192);
            orButton.Enabled = false;
            orButton.FlatStyle = FlatStyle.Popup;
            orButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orButton.ForeColor = Color.FromArgb(128, 64, 64);
            orButton.Location = new Point(395, 366);
            orButton.Name = "orButton";
            orButton.Size = new Size(75, 23);
            orButton.TabIndex = 5;
            orButton.Text = "OR";
            orButton.UseVisualStyleBackColor = false;
            orButton.Click += orButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(218, 131, 131);
            clearButton.FlatStyle = FlatStyle.Popup;
            clearButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.ForeColor = Color.MistyRose;
            clearButton.Location = new Point(366, 436);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(135, 23);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear Filters";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.FromArgb(255, 192, 192);
            filterButton.FlatStyle = FlatStyle.Popup;
            filterButton.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            filterButton.ForeColor = Color.FromArgb(128, 64, 64);
            filterButton.Location = new Point(511, 366);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(75, 23);
            filterButton.TabIndex = 7;
            filterButton.Text = "FILTER";
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.travel;
            pictureBox1.Location = new Point(336, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 514);
            Controls.Add(pictureBox1);
            Controls.Add(filterButton);
            Controls.Add(clearButton);
            Controls.Add(orButton);
            Controls.Add(andButton);
            Controls.Add(filterTextBox);
            Controls.Add(columnsComboBox);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private ComboBox columnsComboBox;
        private TextBox filterTextBox;
        private Button andButton;
        private Button orButton;
        private Button clearButton;
        private Button filterButton;
        private PictureBox pictureBox1;
    }
}