using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Names
{
    public partial class Form1 : Form
    {
        private List<Person> people;

        public Form1()
        {
            InitializeComponent();
            people = new List<Person>  
            {
                new Person("Fekete Róbert", 19, 420000),
                new Person("Nagy Kinga", 25, 670000),
                new Person("Szabó Regina", 15, 543000)
            };
            UpdateListBox();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            int age = Convert.ToInt32(ageNumUpDown.Value);
            //peopleListBox.Items.Add($"{name} ({age})");
            Random r = new Random();
            int salary = r.Next(200, 501) * 1000;
            Person person = new Person(name, age, salary);
            //peopleListBox.Items.Add(person);
            people.Add(person);
            UpdateListBox();
            peopleListBox.SelectedIndex = peopleListBox.Items.Count - 1;
            //peopleListBox.SelectedItem = people.Last();
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
            if (selected == null) return;
            panel.Visible = true;
            selectedNameLabel.Text = "Név: " + selected.Name;
            selectedAgeLabel.Text = "Életkor: " + selected.Age;
            selectedSalaryLabel.Text = "Fizetés: " + selected.Salary + " Ft";
        }

        private void UpdateListBox()
        {
            peopleListBox.SelectionMode = SelectionMode.None;
            peopleListBox.DataSource = null;
            peopleListBox.DataSource = people;
            peopleListBox.SelectionMode = SelectionMode.One;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            /*
            var listboxItem = peopleListBox.Items;
            var result = (from Person p in listboxItem
                         orderby p.Age
                         select p).ToList();
            peopleListBox.Items.Clear();
            MessageBox.Show(result.Count().ToString());
            foreach (var item in result)
            {
                peopleListBox.Items.Add(item);
            }
            */

            /*
            var temp = peopleListBox.Items.Cast<Person>().ToList();
            //foreach (var item in peopleListBox.Items)
            //{
            //    Person p = item as Person;
            //    temp.Add(p);
            //}
            var result = temp.OrderBy(p => p.Age).ToArray();
            peopleListBox.Items.Clear();
            peopleListBox.Items.AddRange(result);
            //foreach (var item in temp)
            //{
            //    peopleListBox.Items.Add(item);
            //}
            */
            people = people.OrderBy(p => p.Age).ToList();
            UpdateListBox();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            //saveFileDialog.InitialDirectory = "H:\\25-26\\prog_12c_2025_normal\\4-Windows-Forms\\2-Names\\bin\\Debug";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.ShowDialog();
        }
    }
}
