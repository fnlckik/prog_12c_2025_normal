using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _1_Hello
{
    public partial class Form1 : Form
    {
        // enum => felsorolás
        private enum Hetvege
        { 
            Pentek = 5,
            Szombat = 6,
            Vasarnap = 7
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void HelloBtn_Click(object sender, EventArgs e)
        {
            // 1-Hello -> Properties -> Output type
            //Console.WriteLine("Hello Világ!");
            // (MessageBoxButtons)3 == MessageBoxButtons.YesNoCancel
            string name = NameTextBox.Text;
            if (name != "")
            {
                GreetLabel.Text = $"Hello {name}!";
            }
            /*
            DialogResult result = MessageBox.Show($"Hello {name}!",
                                                  "Felhasználó köszöntése",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Information);
            */
            //if (result == DialogResult.Yes)
            //{
            //    MessageBox.Show("Az IGEN gombra nyomtál!");
            //}
            //else if (result == DialogResult.No)
            //{
            //    MessageBox.Show("A NEM gombra nyomtál!");
            //}
            //else
            //{
            //    MessageBox.Show("A MÉGSE gombra nyomtál!");
            //}
            /*
            switch (result)
            {
                case DialogResult.Cancel:
                    MessageBox.Show("A MÉGSE gombra nyomtál!");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("Az IGEN gombra nyomtál!");
                    break;
                case DialogResult.No:
                    MessageBox.Show("A NEM gombra nyomtál!");
                    break;
            }
            */
            //MessageBox.Show($"{Hetvege.Szombat}");
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            //GreetLabel.Text = $"Hello {NameTextBox.Text}!";
            //if (NameTextBox.Text != "")
            //{
            //    HelloBtn.Enabled = true;
            //}
            //else
            //{
            //    HelloBtn.Enabled = false;
            //}
            HelloBtn.Enabled = NameTextBox.Text != "";
        }

        private void BoldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(BoldCheckBox.Checked.ToString());
            if (BoldCheckBox.Checked)
            {
                // ???
                //GreetLabel.Font.Bold = true;
                // (FontStyle)3
                GreetLabel.Font = new Font(GreetLabel.Font, FontStyle.Bold | FontStyle.Italic);
            }
            else
            {
                GreetLabel.Font = new Font(GreetLabel.Font, FontStyle.Italic);
            }
        }

        // e: esemény objektum
        // sender: e.target
        private void ColorRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (!rb.Checked) return;
            switch (rb.Text)
            {
                case "Piros":
                    GreetLabel.ForeColor = Color.FromArgb(192, 0, 0);
                    break;
                case "Zöld":
                    GreetLabel.ForeColor = Color.Green;
                    break;
                case "Kék":
                    GreetLabel.ForeColor = Color.Blue;
                    break;
            }
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEvent = e as MouseEventArgs;
            PositionLabel.Text = $"P({mouseEvent.X};{mouseEvent.Y})";
            //Point newLocation = new Point((Panel.Size.Width - PositionLabel.Size.Width) / 2, PositionLabel.Location.Y);
            //PositionLabel.Location = newLocation;
            PositionLabel.Left = (Panel.Width - PositionLabel.Width) / 2;
        }
    }
}
