namespace WindowsFormsApp1
{
    partial class Form2
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
            this.cmbDirection = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.nudStartRadius = new System.Windows.Forms.NumericUpDown();
            this.nudMinRadius = new System.Windows.Forms.NumericUpDown();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.btnColorBorder = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDirection
            // 
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Items.AddRange(new object[] {
            "Горизонтальное",
            "Вертикальное",
            "Диагональное"});
            this.cmbDirection.Location = new System.Drawing.Point(37, 37);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(121, 21);
            this.cmbDirection.TabIndex = 0;
            this.cmbDirection.SelectedIndexChanged += new System.EventHandler(this.cmbDirection_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudAngle);
            this.groupBox1.Controls.Add(this.cmbDirection);
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // nudAngle
            // 
            this.nudAngle.Location = new System.Drawing.Point(37, 64);
            this.nudAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(57, 20);
            this.nudAngle.TabIndex = 1;
            this.nudAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudAngle.ValueChanged += new System.EventHandler(this.nudAngle_ValueChanged);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(23, 145);
            this.tbSpeed.Maximum = 20;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(200, 45);
            this.tbSpeed.TabIndex = 2;
            this.tbSpeed.Value = 5;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // nudStartRadius
            // 
            this.nudStartRadius.Location = new System.Drawing.Point(23, 196);
            this.nudStartRadius.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudStartRadius.Name = "nudStartRadius";
            this.nudStartRadius.Size = new System.Drawing.Size(70, 20);
            this.nudStartRadius.TabIndex = 3;
            this.nudStartRadius.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudStartRadius.ValueChanged += new System.EventHandler(this.nudStartRadius_ValueChanged);
            // 
            // nudMinRadius
            // 
            this.nudMinRadius.Location = new System.Drawing.Point(23, 223);
            this.nudMinRadius.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMinRadius.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMinRadius.Name = "nudMinRadius";
            this.nudMinRadius.Size = new System.Drawing.Size(70, 20);
            this.nudMinRadius.TabIndex = 4;
            this.nudMinRadius.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinRadius.ValueChanged += new System.EventHandler(this.nudMinRadius_ValueChanged);
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(23, 250);
            this.nudWeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(70, 20);
            this.nudWeight.TabIndex = 5;
            this.nudWeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudWeight.ValueChanged += new System.EventHandler(this.nudWeight_ValueChanged);
            // 
            // btnColor1
            // 
            this.btnColor1.Location = new System.Drawing.Point(23, 294);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(75, 23);
            this.btnColor1.TabIndex = 6;
            this.btnColor1.Text = "button1";
            this.btnColor1.UseVisualStyleBackColor = true;
            this.btnColor1.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // btnColor2
            // 
            this.btnColor2.Location = new System.Drawing.Point(23, 323);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(75, 23);
            this.btnColor2.TabIndex = 6;
            this.btnColor2.Text = "button1";
            this.btnColor2.UseVisualStyleBackColor = true;
            this.btnColor2.Click += new System.EventHandler(this.btnColor2_Click);
            // 
            // btnColorBorder
            // 
            this.btnColorBorder.Location = new System.Drawing.Point(23, 352);
            this.btnColorBorder.Name = "btnColorBorder";
            this.btnColorBorder.Size = new System.Drawing.Size(75, 23);
            this.btnColorBorder.TabIndex = 6;
            this.btnColorBorder.Text = "button1";
            this.btnColorBorder.UseVisualStyleBackColor = true;
            this.btnColorBorder.Click += new System.EventHandler(this.btnColorBorder_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 398);
            this.Controls.Add(this.btnColorBorder);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.btnColor1);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.nudMinRadius);
            this.Controls.Add(this.nudStartRadius);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDirection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.NumericUpDown nudStartRadius;
        private System.Windows.Forms.NumericUpDown nudMinRadius;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Button btnColorBorder;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}