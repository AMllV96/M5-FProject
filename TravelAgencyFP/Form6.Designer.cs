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
            label1 = new Label();
            label2 = new Label();
            idTextBox = new TextBox();
            countryTextBox = new TextBox();
            cityTextBox = new TextBox();
            locationTextBox = new TextBox();
            weatherTextBox = new TextBox();
            busynessTextBox = new TextBox();
            updateButton = new Button();
            addButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 118);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 212);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(250, 118);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(150, 31);
            idTextBox.TabIndex = 2;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(245, 212);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.PlaceholderText = "Country";
            countryTextBox.Size = new Size(150, 31);
            countryTextBox.TabIndex = 3;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(246, 276);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.PlaceholderText = "City";
            cityTextBox.Size = new Size(150, 31);
            cityTextBox.TabIndex = 4;
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(245, 333);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.PlaceholderText = "Location";
            locationTextBox.Size = new Size(150, 31);
            locationTextBox.TabIndex = 5;
            // 
            // weatherTextBox
            // 
            weatherTextBox.Location = new Point(429, 216);
            weatherTextBox.Name = "weatherTextBox";
            weatherTextBox.PlaceholderText = "Weather";
            weatherTextBox.Size = new Size(150, 31);
            weatherTextBox.TabIndex = 6;
            // 
            // busynessTextBox
            // 
            busynessTextBox.Location = new Point(433, 283);
            busynessTextBox.Name = "busynessTextBox";
            busynessTextBox.PlaceholderText = "Busyness";
            busynessTextBox.Size = new Size(150, 31);
            busynessTextBox.TabIndex = 7;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(127, 418);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(151, 34);
            updateButton.TabIndex = 8;
            updateButton.Text = "Update record";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(439, 418);
            addButton.Name = "addButton";
            addButton.Size = new Size(144, 34);
            addButton.TabIndex = 9;
            addButton.Text = "Add record";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(busynessTextBox);
            Controls.Add(weatherTextBox);
            Controls.Add(locationTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox idTextBox;
        private TextBox countryTextBox;
        private TextBox cityTextBox;
        private TextBox locationTextBox;
        private TextBox weatherTextBox;
        private TextBox busynessTextBox;
        private Button updateButton;
        private Button addButton;
    }
}