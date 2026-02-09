using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace _3_Tergeometria
{
    public partial class Form1 : Form
    {
        private Shape shape;

        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null) return;
            //ImgPanel.BackgroundImage = Image.FromFile($"../../assets/{rb.Tag}.png");
            double r = (double)RadiusNumericUpDown.Value;
            double m = (double)HeightNumericUpDown.Value;
            switch (rb.Tag)
            {
                case "sphere":
                    ImgPanel.BackgroundImage = Properties.Resources.sphere;
                    shape = new Sphere(r);
                    break;
                case "cylinder":
                    ImgPanel.BackgroundImage = Properties.Resources.cylinder;
                    shape = new Cylinder(r, m);
                    break;
                case "cone":
                    ImgPanel.BackgroundImage = Properties.Resources.cone;
                    shape = new Cone(r, m);
                    break;
            }
            HeightNumericUpDown.Enabled = rb.Tag.ToString() != "sphere";
            CalculatePanel.Enabled = true;
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

        private void RadiusNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CreateShape();
        }

        private void HeightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CreateShape();
        }
    }
}
