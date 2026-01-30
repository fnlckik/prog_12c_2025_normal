using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            peopleListBox.Items.AddRange(new object[] 
            {
                new Person("Fekete Róbert", 19),
                new Person("Nagy Kinga", 25),
                new Person("Szabó Regina", 15)
            });
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int age = Convert.ToInt32(ageNumUpDown.Value);
            peopleListBox.Items.Add($"{name} ({age})");
        }

        private void peopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(peopleListBox.SelectedItem.ToString());
            /*
            string item = peopleListBox.SelectedItem.ToString(); // => "Fekete Róbert (19)"
            string[] temp = item.Split('(');
            string name = temp[0];
            string age = string.Join("", temp[1].Take(temp[1].Length - 1)); // "19)"
            selectedNameLabel.Text = name;
            selectedAgeLabel.Text = age;
            */
            Person selected = peopleListBox.SelectedItem as Person;
            selectedNameLabel.Text = selected.Name;
            selectedAgeLabel.Text = selected.Age.ToString();
        }
    }
}
