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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.cmbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Items.AddRange(new object[] {
            "Горизонтальное",
            "Вертикальное",
            "Диагональное"});
            this.cmbDirection.Location = new System.Drawing.Point(94, 31);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(121, 21);
            this.cmbDirection.TabIndex = 0;
            this.cmbDirection.SelectedIndexChanged += new System.EventHandler(this.cmbDirection_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudAngle);
            this.groupBox1.Controls.Add(this.cmbDirection);
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры траектории";
            // 
            // nudAngle
            // 
            this.nudAngle.Location = new System.Drawing.Point(94, 58);
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
            this.nudAngle.Visible = false;
            this.nudAngle.ValueChanged += new System.EventHandler(this.nudAngle_ValueChanged);
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(23, 162);
            this.tbSpeed.Maximum = 20;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(224, 45);
            this.tbSpeed.TabIndex = 2;
            this.tbSpeed.Value = 5;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // nudStartRadius
            // 
            this.nudStartRadius.Location = new System.Drawing.Point(102, 208);
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
            this.nudMinRadius.Location = new System.Drawing.Point(102, 235);
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
            this.nudWeight.Location = new System.Drawing.Point(102, 262);
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
            this.btnColor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnColor1.Location = new System.Drawing.Point(22, 306);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(76, 52);
            this.btnColor1.TabIndex = 6;
            this.btnColor1.Text = "Цвет 1 (движение вперед)";
            this.btnColor1.UseVisualStyleBackColor = true;
            this.btnColor1.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // btnColor2
            // 
            this.btnColor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnColor2.Location = new System.Drawing.Point(102, 306);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(76, 52);
            this.btnColor2.TabIndex = 6;
            this.btnColor2.Text = "Цвет  2 (движение назад)";
            this.btnColor2.UseVisualStyleBackColor = true;
            this.btnColor2.Click += new System.EventHandler(this.btnColor2_Click);
            // 
            // btnColorBorder
            // 
            this.btnColorBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorBorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColorBorder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnColorBorder.Location = new System.Drawing.Point(184, 306);
            this.btnColorBorder.Name = "btnColorBorder";
            this.btnColorBorder.Size = new System.Drawing.Size(75, 52);
            this.btnColorBorder.TabIndex = 6;
            this.btnColorBorder.Text = "Цвет границы";
            this.btnColorBorder.UseVisualStyleBackColor = true;
            this.btnColorBorder.Click += new System.EventHandler(this.btnColorBorder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Макс. радиус:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Мин. радиус:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вес:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Направление";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Угол:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Скорость:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}