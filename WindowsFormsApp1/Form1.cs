using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public float cx = 100, cy = 100;
        public float vx = 5, vy = 0;
        public float currentRadius = 40;
        public bool isMovingForward = true;

        public int directionIndex = 0; 
        public float movementAngle = 45; 

        public Color color1 = Color.Red;
        public Color color2 = Color.Blue;
        public Color colorBorder = Color.Black;
        public float minRadius = 10;
        public float startRadius = 40;
        public float speed = 5;
        public int weight = 5;

        List<PointF> trail = new List<PointF>();
        int distortionTimer = 0;
        List<Rectangle> obstacles = new List<Rectangle>();
        bool isDragging = false;
        float mouseOffsetX, mouseOffsetY;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                if (currentRadius <= minRadius)
                {
                    currentRadius = startRadius; 
                    trail.Clear();               
                }
            }
            timer1.Enabled = !timer1.Enabled;
            btnStartStop.Text = timer1.Enabled ? "Стоп" : "Старт";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form2 existingForm = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (existingForm == null)
            {
                Form2 f2 = new Form2(this);
                f2.Show();
            }
            else
            {
                existingForm.Activate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isDragging)
            {
                trail.Add(new PointF(cx, cy));
                if (trail.Count > 5) trail.RemoveAt(0);

                cx += vx;
                cy += vy;

                bool bounced = false;

                if (cx - currentRadius <= 0) { cx = currentRadius; vx = -vx; bounced = true; }
                if (cx + currentRadius >= this.ClientSize.Width) { cx = this.ClientSize.Width - currentRadius; vx = -vx; bounced = true; }
                if (cy - currentRadius <= 0) { cy = currentRadius; vy = -vy; bounced = true; }
                if (cy + currentRadius >= this.ClientSize.Height) { cy = this.ClientSize.Height - currentRadius; vy = -vy; bounced = true; }

                RectangleF circleRect = new RectangleF(cx - currentRadius, cy - currentRadius, currentRadius * 2, currentRadius * 2);
                foreach (var obs in obstacles)
                {
                    if (obs.IntersectsWith(Rectangle.Round(circleRect)))
                    {
                        float overlapX = Math.Min(cx + currentRadius, obs.Right) - Math.Max(cx - currentRadius, obs.Left);
                        float overlapY = Math.Min(cy + currentRadius, obs.Bottom) - Math.Max(cy - currentRadius, obs.Top);

                        if (overlapX < overlapY)
                        {
                            vx = -vx;
                            cx += (cx < obs.Left + obs.Width / 2f) ? -overlapX : overlapX;
                        }
                        else
                        {
                            vy = -vy;
                            cy += (cy < obs.Top + obs.Height / 2f) ? -overlapY : overlapY;
                        }

                        bounced = true;
                        break;
                    }
                }

                if (bounced)
                {
                    isMovingForward = !isMovingForward;
                    distortionTimer = 10;

                    float reduction = (11 - weight) * 0.5f;
                    currentRadius -= reduction;

                    if (currentRadius <= minRadius)
                    {
                        timer1.Stop();
                        MessageBox.Show("Радиус достиг минимума!");
                        btnStartStop.Text = "Старт";
                    }
                }

                if (distortionTimer > 0) distortionTimer--;
            }
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var obs in obstacles)
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, obs);
                e.Graphics.DrawRectangle(Pens.Black, obs);
            }

            for (int i = 0; i < trail.Count; i++)
            {
                int alpha = (i * 150) / trail.Count; 
                Color blurColor = Color.FromArgb(alpha, isMovingForward ? color1 : color2);
                using (SolidBrush blurBrush = new SolidBrush(blurColor))
                {
                    e.Graphics.FillEllipse(blurBrush, trail[i].X - currentRadius, trail[i].Y - currentRadius, currentRadius * 2, currentRadius * 2);
                }
            }

            Color currentColor = isMovingForward ? color1 : color2;
            using (SolidBrush mainBrush = new SolidBrush(currentColor))
            using (Pen borderPen = new Pen(colorBorder, 3))
            {
                float drawRadiusX = currentRadius;
                float drawRadiusY = currentRadius;

                if (distortionTimer > 0) 
                {
                    if (Math.Abs(vx) > Math.Abs(vy))
                    {
                        drawRadiusX = currentRadius * 0.8f;
                        drawRadiusY = currentRadius * 1.2f;
                    }
                    else
                    {
                        drawRadiusX = currentRadius * 1.2f;
                        drawRadiusY = currentRadius * 0.8f;
                    }
                }

                e.Graphics.FillEllipse(mainBrush, cx - drawRadiusX, cy - drawRadiusY, drawRadiusX * 2, drawRadiusY * 2);
                e.Graphics.DrawEllipse(borderPen, cx - drawRadiusX, cy - drawRadiusY, drawRadiusX * 2, drawRadiusY * 2);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            float dist = (float)Math.Sqrt(Math.Pow(e.X - cx, 2) + Math.Pow(e.Y - cy, 2));

            if (e.Button == MouseButtons.Left)
            {
                if (dist <= currentRadius)
                {
                    isDragging = true;
                    mouseOffsetX = cx - e.X;
                    mouseOffsetY = cy - e.Y;
                    trail.Clear();
                }
                else
                {
                    vx = -vx;
                    vy = -vy;
                    isMovingForward = !isMovingForward;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                obstacles.Add(new Rectangle(e.X - 20, e.Y - 20, 40, 40));
                this.Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                float targetX = e.X + mouseOffsetX;
                float targetY = e.Y + mouseOffsetY;

                if (targetX - currentRadius < 0) targetX = currentRadius;
                if (targetX + currentRadius > this.ClientSize.Width) targetX = this.ClientSize.Width - currentRadius;
                if (targetY - currentRadius < 0) targetY = currentRadius;
                if (targetY + currentRadius > this.ClientSize.Height) targetY = this.ClientSize.Height - currentRadius;

                cx = targetX;
                cy = targetY;
                this.Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}