using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Hello
{
    public partial class Form1 : Form
    {
        // enum => felsorolás
        private enum Hetvege
        { 
            Szombat = 6,
            Vasarnap = 7
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void HelloBtn_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Hello Világ!");
            //DialogResult result = MessageBox.Show("Hello Világ!", "Felhasználó köszöntése", MessageBoxButtons.YesNoCancel);
            //MessageBox.Show(result == ??);
            MessageBox.Show(((int)Hetvege.Szombat).ToString());
        }
    }
}
