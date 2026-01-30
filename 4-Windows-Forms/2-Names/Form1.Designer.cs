namespace _2_Names
{
    partial class Form1
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
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedAgeLabel = new System.Windows.Forms.Label();
            this.selectedNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // peopleListBox
            // 
            this.peopleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peopleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.ItemHeight = 29;
            this.peopleListBox.Items.AddRange(new object[] {
            "Fekete Róbert (19)",
            "Nagy Kinga (25)",
            "Szabó Regina (15)"});
            this.peopleListBox.Location = new System.Drawing.Point(475, 50);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(286, 323);
            this.peopleListBox.TabIndex = 0;
            this.peopleListBox.SelectedIndexChanged += new System.EventHandler(this.peopleListBox_SelectedIndexChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextBox.Location = new System.Drawing.Point(148, 50);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(230, 32);
            this.nameTextBox.TabIndex = 1;
            // 
            // ageNumUpDown
            // 
            this.ageNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageNumUpDown.Location = new System.Drawing.Point(148, 105);
            this.ageNumUpDown.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.ageNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageNumUpDown.Name = "ageNumUpDown";
            this.ageNumUpDown.Size = new System.Drawing.Size(120, 32);
            this.ageNumUpDown.TabIndex = 2;
            this.ageNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(85, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 26);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Név:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageLabel.Location = new System.Drawing.Point(56, 107);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(86, 26);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Életkor:";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(61, 168);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 42);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Rögzítés";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.selectedAgeLabel);
            this.panel1.Controls.Add(this.selectedNameLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(61, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 221);
            this.panel1.TabIndex = 6;
            // 
            // selectedAgeLabel
            // 
            this.selectedAgeLabel.AutoSize = true;
            this.selectedAgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedAgeLabel.Location = new System.Drawing.Point(44, 150);
            this.selectedAgeLabel.Name = "selectedAgeLabel";
            this.selectedAgeLabel.Size = new System.Drawing.Size(95, 29);
            this.selectedAgeLabel.TabIndex = 2;
            this.selectedAgeLabel.Text = "Életkor:";
            // 
            // selectedNameLabel
            // 
            this.selectedNameLabel.AutoSize = true;
            this.selectedNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedNameLabel.Location = new System.Drawing.Point(44, 92);
            this.selectedNameLabel.Name = "selectedNameLabel";
            this.selectedNameLabel.Size = new System.Drawing.Size(62, 29);
            this.selectedNameLabel.TabIndex = 1;
            this.selectedNameLabel.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(44, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kiválasztott személy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.ageNumUpDown);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.peopleListBox);
            this.MinimumSize = new System.Drawing.Size(816, 550);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown ageNumUpDown;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label selectedAgeLabel;
        private System.Windows.Forms.Label selectedNameLabel;
        private System.Windows.Forms.Label label3;
    }
}

