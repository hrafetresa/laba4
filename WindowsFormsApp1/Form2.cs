using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 main;

        public Form2(Form1 f1)
        {
            InitializeComponent();
            main = f1;

            tbSpeed.Value = (int)main.speed;
            nudStartRadius.Value = (decimal)main.startRadius;
            nudMinRadius.Value = (decimal)main.minRadius;
            nudWeight.Value = main.weight;
            btnColor1.BackColor = main.color1;
            btnColor2.BackColor = main.color2;
            btnColorBorder.BackColor = main.colorBorder;

            nudAngle.Value = (decimal)main.movementAngle;
            cmbDirection.SelectedIndex = main.directionIndex;
        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) { btnColor1.BackColor = colorDialog1.Color; UpdateSettings(); }
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) { btnColor2.BackColor = colorDialog1.Color; UpdateSettings(); }
        }

        private void btnColorBorder_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) { btnColorBorder.BackColor = colorDialog1.Color; UpdateSettings(); }
        }

        private void UpdateSettings()
        {
            main.speed = tbSpeed.Value;
            main.startRadius = (float)nudStartRadius.Value;
            main.minRadius = (float)nudMinRadius.Value;
            main.weight = (int)nudWeight.Value;
            main.color1 = btnColor1.BackColor;
            main.color2 = btnColor2.BackColor;
            main.colorBorder = btnColorBorder.BackColor;

            main.directionIndex = cmbDirection.SelectedIndex;
            main.movementAngle = (float)nudAngle.Value;

            float signX = main.vx >= 0 ? 1f : -1f;
            float signY = main.vy >= 0 ? 1f : -1f;

            if (cmbDirection.SelectedIndex == 0)
            {
                main.vx = signX * main.speed;
                main.vy = 0;
            }
            else if (cmbDirection.SelectedIndex == 1)
            {
                main.vx = 0;
                main.vy = signY * main.speed;
            }
            else if (cmbDirection.SelectedIndex == 2)
            {
                double rad = (double)nudAngle.Value * Math.PI / 180.0;
                main.vx = signX * Math.Abs((float)(main.speed * Math.Cos(rad)));
                main.vy = signY * Math.Abs((float)(main.speed * Math.Sin(rad)));
            }
        }

        private void tbSpeed_Scroll(object sender, EventArgs e) => UpdateSettings();
        private void cmbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudAngle.Visible = label5.Visible = (cmbDirection.SelectedIndex == 2);
            UpdateSettings();
        }
        private void nudAngle_ValueChanged(object sender, EventArgs e) => UpdateSettings();
        private void nudStartRadius_ValueChanged(object sender, EventArgs e)
        {
            UpdateSettings();
            main.currentRadius = main.startRadius;
        }
        private void nudMinRadius_ValueChanged(object sender, EventArgs e) => UpdateSettings();
        private void nudWeight_ValueChanged(object sender, EventArgs e) => UpdateSettings();
    }
}