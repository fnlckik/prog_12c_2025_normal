namespace _3_Tergeometria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConeButton = new System.Windows.Forms.RadioButton();
            this.CylinderButton = new System.Windows.Forms.RadioButton();
            this.SphereButton = new System.Windows.Forms.RadioButton();
            this.ImgPanel = new System.Windows.Forms.Panel();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AreaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VolumeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LargestLabel = new System.Windows.Forms.Label();
            this.ShapeListBox = new System.Windows.Forms.ListBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.CalculatePanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeNumericUpDown)).BeginInit();
            this.CalculatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConeButton);
            this.groupBox1.Controls.Add(this.CylinderButton);
            this.groupBox1.Controls.Add(this.SphereButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 169);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test típusa";
            // 
            // ConeButton
            // 
            this.ConeButton.AutoSize = true;
            this.ConeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConeButton.Location = new System.Drawing.Point(27, 129);
            this.ConeButton.Name = "ConeButton";
            this.ConeButton.Size = new System.Drawing.Size(62, 28);
            this.ConeButton.TabIndex = 69;
            this.ConeButton.TabStop = true;
            this.ConeButton.Tag = "cone";
            this.ConeButton.Text = "Kúp";
            this.ConeButton.UseVisualStyleBackColor = true;
            this.ConeButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // CylinderButton
            // 
            this.CylinderButton.AutoSize = true;
            this.CylinderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CylinderButton.Location = new System.Drawing.Point(27, 88);
            this.CylinderButton.Name = "CylinderButton";
            this.CylinderButton.Size = new System.Drawing.Size(92, 28);
            this.CylinderButton.TabIndex = 68;
            this.CylinderButton.TabStop = true;
            this.CylinderButton.Tag = "cylinder";
            this.CylinderButton.Text = "Henger";
            this.CylinderButton.UseVisualStyleBackColor = true;
            this.CylinderButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // SphereButton
            // 
            this.SphereButton.AutoSize = true;
            this.SphereButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SphereButton.Location = new System.Drawing.Point(27, 46);
            this.SphereButton.Name = "SphereButton";
            this.SphereButton.Size = new System.Drawing.Size(80, 28);
            this.SphereButton.TabIndex = 67;
            this.SphereButton.TabStop = true;
            this.SphereButton.Tag = "sphere";
            this.SphereButton.Text = "Gömb";
            this.SphereButton.UseVisualStyleBackColor = true;
            this.SphereButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // ImgPanel
            // 
            this.ImgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImgPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImgPanel.Location = new System.Drawing.Point(576, 257);
            this.ImgPanel.Name = "ImgPanel";
            this.ImgPanel.Size = new System.Drawing.Size(200, 200);
            this.ImgPanel.TabIndex = 1;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GenerateButton.Location = new System.Drawing.Point(13, 20);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(92, 36);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generál";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(276, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sugár (R):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(237, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Magasság (M):";
            // 
            // RadiusNumericUpDown
            // 
            this.RadiusNumericUpDown.DecimalPlaces = 1;
            this.RadiusNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RadiusNumericUpDown.Location = new System.Drawing.Point(377, 122);
            this.RadiusNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RadiusNumericUpDown.Name = "RadiusNumericUpDown";
            this.RadiusNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.RadiusNumericUpDown.TabIndex = 10;
            this.RadiusNumericUpDown.ValueChanged += new System.EventHandler(this.DataNumericUpDown_ValueChanged);
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.DecimalPlaces = 1;
            this.HeightNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeightNumericUpDown.Location = new System.Drawing.Point(377, 161);
            this.HeightNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.HeightNumericUpDown.TabIndex = 11;
            this.HeightNumericUpDown.ValueChanged += new System.EventHandler(this.DataNumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Felszín: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(255, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Térfogat:";
            // 
            // AreaNumericUpDown
            // 
            this.AreaNumericUpDown.DecimalPlaces = 1;
            this.AreaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AreaNumericUpDown.Location = new System.Drawing.Point(103, 87);
            this.AreaNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.AreaNumericUpDown.Name = "AreaNumericUpDown";
            this.AreaNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.AreaNumericUpDown.TabIndex = 14;
            // 
            // VolumeNumericUpDown
            // 
            this.VolumeNumericUpDown.DecimalPlaces = 1;
            this.VolumeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VolumeNumericUpDown.Location = new System.Drawing.Point(345, 89);
            this.VolumeNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.VolumeNumericUpDown.Name = "VolumeNumericUpDown";
            this.VolumeNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.VolumeNumericUpDown.TabIndex = 15;
            // 
            // LargestLabel
            // 
            this.LargestLabel.AutoSize = true;
            this.LargestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LargestLabel.Location = new System.Drawing.Point(37, 166);
            this.LargestLabel.Name = "LargestLabel";
            this.LargestLabel.Size = new System.Drawing.Size(193, 24);
            this.LargestLabel.TabIndex = 16;
            this.LargestLabel.Text = "Legnagyobb térfogatú";
            // 
            // ShapeListBox
            // 
            this.ShapeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ShapeListBox.FormattingEnabled = true;
            this.ShapeListBox.ItemHeight = 24;
            this.ShapeListBox.Location = new System.Drawing.Point(547, 39);
            this.ShapeListBox.Name = "ShapeListBox";
            this.ShapeListBox.Size = new System.Drawing.Size(229, 172);
            this.ShapeListBox.TabIndex = 17;
            this.ShapeListBox.SelectedIndexChanged += new System.EventHandler(this.ShapeListBox_SelectedIndexChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CalculateButton.Location = new System.Drawing.Point(131, 20);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(92, 36);
            this.CalculateButton.TabIndex = 18;
            this.CalculateButton.Text = "Számol";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckButton.Location = new System.Drawing.Point(259, 20);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(92, 36);
            this.CheckButton.TabIndex = 19;
            this.CheckButton.Text = "Ellenőriz";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddButton.Location = new System.Drawing.Point(382, 20);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(92, 36);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Tárol";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveButton.ForeColor = System.Drawing.Color.Blue;
            this.SaveButton.Location = new System.Drawing.Point(286, 39);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(92, 62);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "💾";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenButton.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.OpenButton.Location = new System.Drawing.Point(405, 39);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(92, 62);
            this.OpenButton.TabIndex = 22;
            this.OpenButton.Text = "📂";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // CalculatePanel
            // 
            this.CalculatePanel.Controls.Add(this.CalculateButton);
            this.CalculatePanel.Controls.Add(this.GenerateButton);
            this.CalculatePanel.Controls.Add(this.AddButton);
            this.CalculatePanel.Controls.Add(this.AreaNumericUpDown);
            this.CalculatePanel.Controls.Add(this.VolumeNumericUpDown);
            this.CalculatePanel.Controls.Add(this.CheckButton);
            this.CalculatePanel.Controls.Add(this.label4);
            this.CalculatePanel.Controls.Add(this.LargestLabel);
            this.CalculatePanel.Controls.Add(this.label3);
            this.CalculatePanel.Enabled = false;
            this.CalculatePanel.Location = new System.Drawing.Point(27, 216);
            this.CalculatePanel.Name = "CalculatePanel";
            this.CalculatePanel.Size = new System.Drawing.Size(499, 241);
            this.CalculatePanel.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ShapeListBox);
            this.Controls.Add(this.HeightNumericUpDown);
            this.Controls.Add(this.RadiusNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImgPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CalculatePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AreaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeNumericUpDown)).EndInit();
            this.CalculatePanel.ResumeLayout(false);
            this.CalculatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel ImgPanel;
        private System.Windows.Forms.RadioButton ConeButton;
        private System.Windows.Forms.RadioButton CylinderButton;
        private System.Windows.Forms.RadioButton SphereButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown RadiusNumericUpDown;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown AreaNumericUpDown;
        private System.Windows.Forms.NumericUpDown VolumeNumericUpDown;
        private System.Windows.Forms.Label LargestLabel;
        private System.Windows.Forms.ListBox ShapeListBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Panel CalculatePanel;
    }
}

