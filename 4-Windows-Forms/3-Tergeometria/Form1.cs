using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace _3_Tergeometria
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes = new List<Shape>();
        private Shape shape; // aktuális alakzat

        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null) return;
            //ImgPanel.BackgroundImage = Image.FromFile($"../../assets/{rb.Tag}.png");
            switch (rb.Tag)
            {
                case "sphere":
                    ImgPanel.BackgroundImage = Properties.Resources.sphere;
                    break;
                case "cylinder":
                    ImgPanel.BackgroundImage = Properties.Resources.cylinder;
                    break;
                case "cone":
                    ImgPanel.BackgroundImage = Properties.Resources.cone;
                    break;
            }
            HeightNumericUpDown.Enabled = rb.Tag.ToString() != "sphere";
            CalculatePanel.Enabled = true;
            CreateShape();
            //MessageBox.Show($"{shape.GetType().Name} {rb.Tag}");
            var largestShape = shapes.Where(s => s.GetType().Name.ToLower() == rb.Tag.ToString())
                                     .OrderByDescending(s => s.Volume)
                                     .FirstOrDefault();
            LargestLabel.Text = "Legnagyobb térfogatú " + largestShape;
        }

        private void CreateShape()
        {
            double r = (double)RadiusNumericUpDown.Value;
            double m = (double)HeightNumericUpDown.Value;
            if (SphereButton.Checked)
            {
                shape = new Sphere(r);
            }
            else if (CylinderButton.Checked)
            {
                shape = new Cylinder(r, m);
            }
            else if (ConeButton.Checked)
            {
                shape = new Cone(r, m);
            }
            AreaNumericUpDown.Value = 0;
            VolumeNumericUpDown.Value = 0;
            AreaNumericUpDown.BackColor = SystemColors.Window;
            VolumeNumericUpDown.BackColor = SystemColors.Window;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double r = Math.Round(rand.NextDouble() * 10, 1);
            double m = Math.Round(rand.NextDouble() * 10, 1);
            RadiusNumericUpDown.Value = (decimal)r;
            HeightNumericUpDown.Value = (decimal)m;
            CreateShape();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            AreaNumericUpDown.Value = (decimal)shape.Area;
            VolumeNumericUpDown.Value = (decimal)shape.Volume;
        }

        private void DataNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CreateShape();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{Math.Round((double)AreaNumericUpDown.Value, 1, MidpointRounding.AwayFromZero)} {Math.Round(shape.Area, 1, MidpointRounding.AwayFromZero)}");
            bool isCorrect = Math.Round((double)AreaNumericUpDown.Value, 1) == Math.Round(shape.Area, 1);
            AreaNumericUpDown.BackColor = isCorrect ? Color.LightGreen : Color.LightPink;
            isCorrect = Math.Round((double)VolumeNumericUpDown.Value, 1) == Math.Round(shape.Volume, 1);
            VolumeNumericUpDown.BackColor = isCorrect ? Color.LightGreen : Color.LightPink;
        }

        private void UpdateList()
        {
            //ShapeListBox.Items.Clear();
            //ShapeListBox.Items.AddRange(shapes.ToArray());
            ShapeListBox.SelectionMode = SelectionMode.None;
            ShapeListBox.DataSource = null;
            ShapeListBox.DataSource = shapes;
            ShapeListBox.SelectionMode = SelectionMode.One;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            shapes.Add(shape);
            UpdateList();
        }

        private void ShapeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shape shape = ShapeListBox.SelectedItem as Shape;
            //if (shape == null) return;
            RadiusNumericUpDown.Value = (decimal)shape.r;
            HeightNumericUpDown.Value = (decimal)shape.m;
            if (shape is Sphere) SphereButton.Checked = true;
            else if (shape is Cylinder) CylinderButton.Checked = true;
            else if (shape is Cone) ConeButton.Checked = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Application.StartupPath;
            dialog.Filter = "Szöveges fájl|*.txt|Minden fájl|*.*";
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;
            string path = dialog.FileName;
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var shape in shapes)
                {
                    //if (shape is Sphere)
                    //{
                    //    sw.WriteLine($"G;{shape.r}");
                    //}
                    //else if (shape is Cylinder)
                    //{
                    //    sw.WriteLine($"H;{shape.r};{shape.m}");
                    //}
                    //else
                    //{
                    //    sw.WriteLine($"K;{shape.r};{shape.m}");
                    //}
                    //sw.WriteLine(shape);
                    string end = shape is Sphere ? "" : (";" + shape.m);
                    sw.WriteLine($"{shape.ToString()[0]};{shape.r}{end}");
                }
            }
        }
    }
}
