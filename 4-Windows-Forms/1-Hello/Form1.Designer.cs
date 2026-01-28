namespace _1_Hello
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
            this.HelloBtn = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GreetLabel = new System.Windows.Forms.Label();
            this.BoldCheckBox = new System.Windows.Forms.CheckBox();
            this.RedRadio = new System.Windows.Forms.RadioButton();
            this.GreenRadio = new System.Windows.Forms.RadioButton();
            this.BlueRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelloBtn
            // 
            this.HelloBtn.Enabled = false;
            this.HelloBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelloBtn.Location = new System.Drawing.Point(484, 86);
            this.HelloBtn.Name = "HelloBtn";
            this.HelloBtn.Size = new System.Drawing.Size(231, 87);
            this.HelloBtn.TabIndex = 0;
            this.HelloBtn.Text = "Hello!";
            this.HelloBtn.UseVisualStyleBackColor = true;
            this.HelloBtn.Click += new System.EventHandler(this.HelloBtn_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.Location = new System.Drawing.Point(200, 115);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(184, 29);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.Location = new System.Drawing.Point(125, 115);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(66, 29);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Név:";
            // 
            // GreetLabel
            // 
            this.GreetLabel.AutoSize = true;
            this.GreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GreetLabel.Location = new System.Drawing.Point(479, 209);
            this.GreetLabel.Name = "GreetLabel";
            this.GreetLabel.Size = new System.Drawing.Size(0, 29);
            this.GreetLabel.TabIndex = 3;
            // 
            // BoldCheckBox
            // 
            this.BoldCheckBox.AutoSize = true;
            this.BoldCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BoldCheckBox.Location = new System.Drawing.Point(130, 183);
            this.BoldCheckBox.Name = "BoldCheckBox";
            this.BoldCheckBox.Size = new System.Drawing.Size(138, 33);
            this.BoldCheckBox.TabIndex = 4;
            this.BoldCheckBox.Text = "Félkövér?";
            this.BoldCheckBox.UseVisualStyleBackColor = true;
            this.BoldCheckBox.CheckedChanged += new System.EventHandler(this.BoldCheckBox_CheckedChanged);
            // 
            // RedRadio
            // 
            this.RedRadio.AutoSize = true;
            this.RedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RedRadio.Location = new System.Drawing.Point(54, 61);
            this.RedRadio.Name = "RedRadio";
            this.RedRadio.Size = new System.Drawing.Size(87, 33);
            this.RedRadio.TabIndex = 5;
            this.RedRadio.TabStop = true;
            this.RedRadio.Text = "Piros";
            this.RedRadio.UseVisualStyleBackColor = true;
            this.RedRadio.CheckedChanged += new System.EventHandler(this.ColorRadio_CheckedChanged);
            // 
            // GreenRadio
            // 
            this.GreenRadio.AutoSize = true;
            this.GreenRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GreenRadio.Location = new System.Drawing.Point(54, 116);
            this.GreenRadio.Name = "GreenRadio";
            this.GreenRadio.Size = new System.Drawing.Size(79, 33);
            this.GreenRadio.TabIndex = 6;
            this.GreenRadio.TabStop = true;
            this.GreenRadio.Text = "Zöld";
            this.GreenRadio.UseVisualStyleBackColor = true;
            this.GreenRadio.CheckedChanged += new System.EventHandler(this.ColorRadio_CheckedChanged);
            // 
            // BlueRadio
            // 
            this.BlueRadio.AutoSize = true;
            this.BlueRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BlueRadio.Location = new System.Drawing.Point(54, 171);
            this.BlueRadio.Name = "BlueRadio";
            this.BlueRadio.Size = new System.Drawing.Size(73, 33);
            this.BlueRadio.TabIndex = 7;
            this.BlueRadio.TabStop = true;
            this.BlueRadio.Text = "Kék";
            this.BlueRadio.UseVisualStyleBackColor = true;
            this.BlueRadio.CheckedChanged += new System.EventHandler(this.ColorRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RedRadio);
            this.groupBox1.Controls.Add(this.GreenRadio);
            this.groupBox1.Controls.Add(this.BlueRadio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(64, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 245);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betűszín választó";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.Controls.Add(this.PositionLabel);
            this.Panel.Location = new System.Drawing.Point(484, 259);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(231, 245);
            this.Panel.TabIndex = 11;
            this.Panel.Click += new System.EventHandler(this.Panel_Click);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PositionLabel.Location = new System.Drawing.Point(79, 108);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(73, 29);
            this.PositionLabel.TabIndex = 12;
            this.PositionLabel.Text = "P(x;y)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BoldCheckBox);
            this.Controls.Add(this.GreetLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.HelloBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hello Grafikus Világ!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HelloBtn;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label GreetLabel;
        private System.Windows.Forms.CheckBox BoldCheckBox;
        private System.Windows.Forms.RadioButton RedRadio;
        private System.Windows.Forms.RadioButton GreenRadio;
        private System.Windows.Forms.RadioButton BlueRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label PositionLabel;
    }
}

