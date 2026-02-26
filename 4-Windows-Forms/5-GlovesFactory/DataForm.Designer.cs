namespace GlovesFactory
{
    partial class DataForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.StatsGroupBox = new System.Windows.Forms.GroupBox();
            this.MagnitudeLabel = new System.Windows.Forms.Label();
            this.MedianLabel = new System.Windows.Forms.Label();
            this.SpreadLabel = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.ExtremeGroupBox = new System.Windows.Forms.GroupBox();
            this.ExtremeCheckBox = new System.Windows.Forms.CheckBox();
            this.TopNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.BottomNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaterialDataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.adatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatsGroupBox.SuspendLayout();
            this.ExtremeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialDataGrid)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategória:";
            // 
            // StatsGroupBox
            // 
            this.StatsGroupBox.Controls.Add(this.MagnitudeLabel);
            this.StatsGroupBox.Controls.Add(this.MedianLabel);
            this.StatsGroupBox.Controls.Add(this.SpreadLabel);
            this.StatsGroupBox.Controls.Add(this.label1);
            this.StatsGroupBox.Controls.Add(this.AverageLabel);
            this.StatsGroupBox.Enabled = false;
            this.StatsGroupBox.Location = new System.Drawing.Point(29, 247);
            this.StatsGroupBox.Name = "StatsGroupBox";
            this.StatsGroupBox.Size = new System.Drawing.Size(378, 174);
            this.StatsGroupBox.TabIndex = 4;
            this.StatsGroupBox.TabStop = false;
            this.StatsGroupBox.Text = "Statisztikák";
            // 
            // MagnitudeLabel
            // 
            this.MagnitudeLabel.AutoSize = true;
            this.MagnitudeLabel.Location = new System.Drawing.Point(202, 92);
            this.MagnitudeLabel.Name = "MagnitudeLabel";
            this.MagnitudeLabel.Size = new System.Drawing.Size(91, 20);
            this.MagnitudeLabel.TabIndex = 3;
            this.MagnitudeLabel.Text = "Terjedelem:";
            // 
            // MedianLabel
            // 
            this.MedianLabel.AutoSize = true;
            this.MedianLabel.Location = new System.Drawing.Point(48, 92);
            this.MedianLabel.Name = "MedianLabel";
            this.MedianLabel.Size = new System.Drawing.Size(65, 20);
            this.MedianLabel.TabIndex = 2;
            this.MedianLabel.Text = "Medián:";
            // 
            // SpreadLabel
            // 
            this.SpreadLabel.AutoSize = true;
            this.SpreadLabel.Location = new System.Drawing.Point(230, 129);
            this.SpreadLabel.Name = "SpreadLabel";
            this.SpreadLabel.Size = new System.Drawing.Size(63, 20);
            this.SpreadLabel.TabIndex = 1;
            this.SpreadLabel.Text = "Szórás:";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(63, 129);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(50, 20);
            this.AverageLabel.TabIndex = 0;
            this.AverageLabel.Text = "Átlag:";
            // 
            // ExtremeGroupBox
            // 
            this.ExtremeGroupBox.Controls.Add(this.ExtremeCheckBox);
            this.ExtremeGroupBox.Controls.Add(this.TopNumUpDown);
            this.ExtremeGroupBox.Controls.Add(this.BottomNumUpDown);
            this.ExtremeGroupBox.Controls.Add(this.label3);
            this.ExtremeGroupBox.Controls.Add(this.label2);
            this.ExtremeGroupBox.Enabled = false;
            this.ExtremeGroupBox.Location = new System.Drawing.Point(29, 50);
            this.ExtremeGroupBox.Name = "ExtremeGroupBox";
            this.ExtremeGroupBox.Size = new System.Drawing.Size(160, 178);
            this.ExtremeGroupBox.TabIndex = 5;
            this.ExtremeGroupBox.TabStop = false;
            this.ExtremeGroupBox.Text = "Kiugró adatok";
            // 
            // ExtremeCheckBox
            // 
            this.ExtremeCheckBox.AllowDrop = true;
            this.ExtremeCheckBox.AutoSize = true;
            this.ExtremeCheckBox.Location = new System.Drawing.Point(17, 133);
            this.ExtremeCheckBox.Name = "ExtremeCheckBox";
            this.ExtremeCheckBox.Size = new System.Drawing.Size(130, 24);
            this.ExtremeCheckBox.TabIndex = 4;
            this.ExtremeCheckBox.Text = "Kiugró értékek";
            this.ExtremeCheckBox.UseVisualStyleBackColor = true;
            // 
            // TopNumUpDown
            // 
            this.TopNumUpDown.Location = new System.Drawing.Point(67, 88);
            this.TopNumUpDown.Name = "TopNumUpDown";
            this.TopNumUpDown.Size = new System.Drawing.Size(80, 26);
            this.TopNumUpDown.TabIndex = 3;
            // 
            // BottomNumUpDown
            // 
            this.BottomNumUpDown.Location = new System.Drawing.Point(67, 45);
            this.BottomNumUpDown.Name = "BottomNumUpDown";
            this.BottomNumUpDown.Size = new System.Drawing.Size(80, 26);
            this.BottomNumUpDown.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Felső:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alsó:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(207, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 178);
            this.panel1.TabIndex = 5;
            // 
            // MaterialDataGrid
            // 
            this.MaterialDataGrid.AllowUserToAddRows = false;
            this.MaterialDataGrid.AllowUserToDeleteRows = false;
            this.MaterialDataGrid.AllowUserToResizeColumns = false;
            this.MaterialDataGrid.AllowUserToResizeRows = false;
            this.MaterialDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MaterialDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaterialDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MaterialDataGrid.Location = new System.Drawing.Point(425, 37);
            this.MaterialDataGrid.Name = "MaterialDataGrid";
            this.MaterialDataGrid.RowHeadersVisible = false;
            this.MaterialDataGrid.Size = new System.Drawing.Size(472, 384);
            this.MaterialDataGrid.TabIndex = 6;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adatokToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(909, 38);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // adatokToolStripMenuItem
            // 
            this.adatokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RandomMenuItem});
            this.adatokToolStripMenuItem.Name = "adatokToolStripMenuItem";
            this.adatokToolStripMenuItem.Size = new System.Drawing.Size(91, 34);
            this.adatokToolStripMenuItem.Text = "Adatok";
            // 
            // RandomMenuItem
            // 
            this.RandomMenuItem.Name = "RandomMenuItem";
            this.RandomMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RandomMenuItem.Size = new System.Drawing.Size(236, 34);
            this.RandomMenuItem.Text = "Random";
            this.RandomMenuItem.Click += new System.EventHandler(this.RandomMenuItem_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 435);
            this.Controls.Add(this.MaterialDataGrid);
            this.Controls.Add(this.ExtremeGroupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StatsGroupBox);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DataForm";
            this.Text = "Kesztyűgyár - Felhasznált bőr";
            this.StatsGroupBox.ResumeLayout(false);
            this.StatsGroupBox.PerformLayout();
            this.ExtremeGroupBox.ResumeLayout(false);
            this.ExtremeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialDataGrid)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox StatsGroupBox;
        private System.Windows.Forms.Label SpreadLabel;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MagnitudeLabel;
        private System.Windows.Forms.Label MedianLabel;
        private System.Windows.Forms.GroupBox ExtremeGroupBox;
        private System.Windows.Forms.CheckBox ExtremeCheckBox;
        private System.Windows.Forms.NumericUpDown TopNumUpDown;
        private System.Windows.Forms.NumericUpDown BottomNumUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView MaterialDataGrid;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem adatokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RandomMenuItem;
    }
}

