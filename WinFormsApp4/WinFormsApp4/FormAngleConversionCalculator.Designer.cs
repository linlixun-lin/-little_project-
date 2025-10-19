namespace WinFormsApp4
{
    partial class FormAngleConversionCalculator
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
            groupBox12 = new GroupBox();
            ang2rad_rad = new TextBox();
            ang2rad_ang = new TextBox();
            label12 = new Label();
            label11 = new Label();
            ang2rad_new = new Button();
            ang2rad_cal = new Button();
            groupBox9 = new GroupBox();
            rad2ang_new = new Button();
            rad2ang_cal = new Button();
            label10 = new Label();
            label9 = new Label();
            rad2ang_ang = new TextBox();
            rad2ang_rad = new TextBox();
            groupBox6 = new GroupBox();
            ang2dfm_dfm = new TextBox();
            ang2dfm_ang = new TextBox();
            label8 = new Label();
            label7 = new Label();
            ang2dfm_new = new Button();
            ang2dfm_cal = new Button();
            groupBox3 = new GroupBox();
            dfm2ang_new = new Button();
            dfm2ang_cal = new Button();
            dfm2ang_ang = new TextBox();
            dfm2ang_dfm = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            dfm2rad_new = new Button();
            dfm2rad_cal = new Button();
            dfm2rad_rad = new TextBox();
            dfm2rad_dfm = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rad2dfm_new = new Button();
            rad2dfm_cal = new Button();
            rad2dfm_dfm = new TextBox();
            rad2dfm_rad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox12.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(ang2rad_rad);
            groupBox12.Controls.Add(ang2rad_ang);
            groupBox12.Controls.Add(label12);
            groupBox12.Controls.Add(label11);
            groupBox12.Controls.Add(ang2rad_new);
            groupBox12.Controls.Add(ang2rad_cal);
            groupBox12.Location = new Point(915, 47);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(150, 356);
            groupBox12.TabIndex = 11;
            groupBox12.TabStop = false;
            groupBox12.Text = "10进制度转弧度";
            // 
            // ang2rad_rad
            // 
            ang2rad_rad.Location = new Point(25, 164);
            ang2rad_rad.Name = "ang2rad_rad";
            ang2rad_rad.ReadOnly = true;
            ang2rad_rad.Size = new Size(104, 27);
            ang2rad_rad.TabIndex = 5;
            // 
            // ang2rad_ang
            // 
            ang2rad_ang.Location = new Point(25, 92);
            ang2rad_ang.Name = "ang2rad_ang";
            ang2rad_ang.Size = new Size(104, 27);
            ang2rad_ang.TabIndex = 4;
            ang2rad_ang.KeyPress += ang2rad_ang_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 134);
            label12.Name = "label12";
            label12.Size = new Size(39, 20);
            label12.TabIndex = 3;
            label12.Text = "弧度";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 62);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 2;
            label11.Text = "10进制度";
            // 
            // ang2rad_new
            // 
            ang2rad_new.Location = new Point(21, 312);
            ang2rad_new.Name = "ang2rad_new";
            ang2rad_new.Size = new Size(94, 29);
            ang2rad_new.TabIndex = 1;
            ang2rad_new.Text = "重置";
            ang2rad_new.UseVisualStyleBackColor = true;
            ang2rad_new.Click += ang2rad_new_Click;
            // 
            // ang2rad_cal
            // 
            ang2rad_cal.Location = new Point(21, 251);
            ang2rad_cal.Name = "ang2rad_cal";
            ang2rad_cal.Size = new Size(94, 29);
            ang2rad_cal.TabIndex = 0;
            ang2rad_cal.Text = "计算";
            ang2rad_cal.UseVisualStyleBackColor = true;
            ang2rad_cal.Click += ang2rad_cal_Click;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(rad2ang_new);
            groupBox9.Controls.Add(rad2ang_cal);
            groupBox9.Controls.Add(label10);
            groupBox9.Controls.Add(label9);
            groupBox9.Controls.Add(rad2ang_ang);
            groupBox9.Controls.Add(rad2ang_rad);
            groupBox9.Location = new Point(749, 47);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(137, 356);
            groupBox9.TabIndex = 10;
            groupBox9.TabStop = false;
            groupBox9.Text = "弧度转10进制度";
            // 
            // rad2ang_new
            // 
            rad2ang_new.Location = new Point(16, 312);
            rad2ang_new.Name = "rad2ang_new";
            rad2ang_new.Size = new Size(94, 29);
            rad2ang_new.TabIndex = 5;
            rad2ang_new.Text = "重置";
            rad2ang_new.UseVisualStyleBackColor = true;
            rad2ang_new.Click += rad2ang_new_Click;
            // 
            // rad2ang_cal
            // 
            rad2ang_cal.Location = new Point(16, 251);
            rad2ang_cal.Name = "rad2ang_cal";
            rad2ang_cal.Size = new Size(94, 29);
            rad2ang_cal.TabIndex = 4;
            rad2ang_cal.Text = "计算";
            rad2ang_cal.UseVisualStyleBackColor = true;
            rad2ang_cal.Click += rad2ang_cal_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 141);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 3;
            label10.Text = "10进制度";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 69);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 2;
            label9.Text = "弧度";
            // 
            // rad2ang_ang
            // 
            rad2ang_ang.Location = new Point(12, 167);
            rad2ang_ang.Name = "rad2ang_ang";
            rad2ang_ang.ReadOnly = true;
            rad2ang_ang.Size = new Size(98, 27);
            rad2ang_ang.TabIndex = 1;
            // 
            // rad2ang_rad
            // 
            rad2ang_rad.Location = new Point(12, 92);
            rad2ang_rad.Name = "rad2ang_rad";
            rad2ang_rad.Size = new Size(98, 27);
            rad2ang_rad.TabIndex = 0;
            rad2ang_rad.KeyPress += rad2ang_rad_KeyPress;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(ang2dfm_dfm);
            groupBox6.Controls.Add(ang2dfm_ang);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(ang2dfm_new);
            groupBox6.Controls.Add(ang2dfm_cal);
            groupBox6.Location = new Point(575, 47);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(139, 356);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            groupBox6.Text = "10进制度转度分秒";
            // 
            // ang2dfm_dfm
            // 
            ang2dfm_dfm.Location = new Point(17, 167);
            ang2dfm_dfm.Name = "ang2dfm_dfm";
            ang2dfm_dfm.ReadOnly = true;
            ang2dfm_dfm.Size = new Size(98, 27);
            ang2dfm_dfm.TabIndex = 5;
            // 
            // ang2dfm_ang
            // 
            ang2dfm_ang.Location = new Point(17, 92);
            ang2dfm_ang.Name = "ang2dfm_ang";
            ang2dfm_ang.Size = new Size(98, 27);
            ang2dfm_ang.TabIndex = 4;
            ang2dfm_ang.KeyPress += ang2dfm_ang_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 144);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 3;
            label8.Text = "度分秒";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 69);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 2;
            label7.Text = "10进制度";
            // 
            // ang2dfm_new
            // 
            ang2dfm_new.Location = new Point(17, 312);
            ang2dfm_new.Name = "ang2dfm_new";
            ang2dfm_new.Size = new Size(94, 29);
            ang2dfm_new.TabIndex = 1;
            ang2dfm_new.Text = "重置";
            ang2dfm_new.UseVisualStyleBackColor = true;
            ang2dfm_new.Click += ang2dfm_new_Click;
            // 
            // ang2dfm_cal
            // 
            ang2dfm_cal.Location = new Point(17, 251);
            ang2dfm_cal.Name = "ang2dfm_cal";
            ang2dfm_cal.Size = new Size(94, 29);
            ang2dfm_cal.TabIndex = 0;
            ang2dfm_cal.Text = "计算";
            ang2dfm_cal.UseVisualStyleBackColor = true;
            ang2dfm_cal.Click += ang2dfm_cal_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dfm2ang_new);
            groupBox3.Controls.Add(dfm2ang_cal);
            groupBox3.Controls.Add(dfm2ang_ang);
            groupBox3.Controls.Add(dfm2ang_dfm);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(404, 47);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(131, 356);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "度分秒转10进制度";
            // 
            // dfm2ang_new
            // 
            dfm2ang_new.Location = new Point(16, 312);
            dfm2ang_new.Name = "dfm2ang_new";
            dfm2ang_new.Size = new Size(94, 29);
            dfm2ang_new.TabIndex = 8;
            dfm2ang_new.Text = "重置";
            dfm2ang_new.UseVisualStyleBackColor = true;
            dfm2ang_new.Click += dfm2ang_new_Click;
            // 
            // dfm2ang_cal
            // 
            dfm2ang_cal.Location = new Point(16, 251);
            dfm2ang_cal.Name = "dfm2ang_cal";
            dfm2ang_cal.Size = new Size(94, 29);
            dfm2ang_cal.TabIndex = 7;
            dfm2ang_cal.Text = "计算";
            dfm2ang_cal.UseVisualStyleBackColor = true;
            dfm2ang_cal.Click += dfm2ang_cal_Click;
            // 
            // dfm2ang_ang
            // 
            dfm2ang_ang.Location = new Point(16, 167);
            dfm2ang_ang.Name = "dfm2ang_ang";
            dfm2ang_ang.ReadOnly = true;
            dfm2ang_ang.Size = new Size(102, 27);
            dfm2ang_ang.TabIndex = 6;
            // 
            // dfm2ang_dfm
            // 
            dfm2ang_dfm.Location = new Point(16, 92);
            dfm2ang_dfm.Name = "dfm2ang_dfm";
            dfm2ang_dfm.Size = new Size(102, 27);
            dfm2ang_dfm.TabIndex = 5;
            dfm2ang_dfm.KeyPress += dfm2ang_dfm_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 144);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 4;
            label6.Text = "10进制度";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 69);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 3;
            label5.Text = "度分秒";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dfm2rad_new);
            groupBox2.Controls.Add(dfm2rad_cal);
            groupBox2.Controls.Add(dfm2rad_rad);
            groupBox2.Controls.Add(dfm2rad_dfm);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(248, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(131, 356);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "度分秒转弧度";
            // 
            // dfm2rad_new
            // 
            dfm2rad_new.Location = new Point(16, 312);
            dfm2rad_new.Name = "dfm2rad_new";
            dfm2rad_new.Size = new Size(94, 29);
            dfm2rad_new.TabIndex = 5;
            dfm2rad_new.Text = "重置";
            dfm2rad_new.UseVisualStyleBackColor = true;
            dfm2rad_new.Click += dfm2rad_new_Click;
            // 
            // dfm2rad_cal
            // 
            dfm2rad_cal.Location = new Point(16, 251);
            dfm2rad_cal.Name = "dfm2rad_cal";
            dfm2rad_cal.Size = new Size(94, 29);
            dfm2rad_cal.TabIndex = 4;
            dfm2rad_cal.Text = "计算";
            dfm2rad_cal.UseVisualStyleBackColor = true;
            dfm2rad_cal.Click += dfm2rad_cal_Click;
            // 
            // dfm2rad_rad
            // 
            dfm2rad_rad.Location = new Point(15, 167);
            dfm2rad_rad.Name = "dfm2rad_rad";
            dfm2rad_rad.ReadOnly = true;
            dfm2rad_rad.Size = new Size(107, 27);
            dfm2rad_rad.TabIndex = 3;
            // 
            // dfm2rad_dfm
            // 
            dfm2rad_dfm.Location = new Point(15, 92);
            dfm2rad_dfm.Name = "dfm2rad_dfm";
            dfm2rad_dfm.Size = new Size(107, 27);
            dfm2rad_dfm.TabIndex = 2;
            dfm2rad_dfm.KeyPress += dfm2rad_dfm_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 144);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 1;
            label4.Text = "弧度";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 69);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 0;
            label3.Text = "度分秒";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad2dfm_new);
            groupBox1.Controls.Add(rad2dfm_cal);
            groupBox1.Controls.Add(rad2dfm_dfm);
            groupBox1.Controls.Add(rad2dfm_rad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(64, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(135, 356);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "弧度转度分秒";
            // 
            // rad2dfm_new
            // 
            rad2dfm_new.Location = new Point(19, 312);
            rad2dfm_new.Name = "rad2dfm_new";
            rad2dfm_new.Size = new Size(94, 29);
            rad2dfm_new.TabIndex = 5;
            rad2dfm_new.Text = "重置";
            rad2dfm_new.UseVisualStyleBackColor = true;
            rad2dfm_new.Click += rad2dfm_new_Click;
            // 
            // rad2dfm_cal
            // 
            rad2dfm_cal.Location = new Point(19, 251);
            rad2dfm_cal.Name = "rad2dfm_cal";
            rad2dfm_cal.Size = new Size(94, 29);
            rad2dfm_cal.TabIndex = 4;
            rad2dfm_cal.Text = "计算";
            rad2dfm_cal.UseVisualStyleBackColor = true;
            rad2dfm_cal.Click += rad2dfm_cal_Click;
            // 
            // rad2dfm_dfm
            // 
            rad2dfm_dfm.Location = new Point(19, 164);
            rad2dfm_dfm.Name = "rad2dfm_dfm";
            rad2dfm_dfm.ReadOnly = true;
            rad2dfm_dfm.Size = new Size(98, 27);
            rad2dfm_dfm.TabIndex = 3;
            // 
            // rad2dfm_rad
            // 
            rad2dfm_rad.Location = new Point(19, 92);
            rad2dfm_rad.Name = "rad2dfm_rad";
            rad2dfm_rad.Size = new Size(98, 27);
            rad2dfm_rad.TabIndex = 2;
            rad2dfm_rad.KeyPress += rad2dfm_rad_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 141);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "度分秒";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 69);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "弧度";
            // 
            // FormAngleConversionCalculator
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 533);
            Controls.Add(groupBox1);
            Controls.Add(groupBox12);
            Controls.Add(groupBox9);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "FormAngleConversionCalculator";
            Text = "角度转换";
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox12;
        private GroupBox groupBox9;
        private GroupBox groupBox6;
        private Button ang2dfm_new;
        private Button ang2dfm_cal;
        private GroupBox groupBox3;
        private Button dfm2ang_new;
        private Button dfm2ang_cal;
        private TextBox dfm2ang_ang;
        private TextBox dfm2ang_dfm;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private Button dfm2rad_new;
        private Button dfm2rad_cal;
        private TextBox dfm2rad_rad;
        private TextBox dfm2rad_dfm;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private Button rad2dfm_new;
        private Button rad2dfm_cal;
        private TextBox rad2dfm_dfm;
        private TextBox rad2dfm_rad;
        private Label label2;
        private Label label1;
        private Button rad2ang_new;
        private Button rad2ang_cal;
        private Label label10;
        private Label label9;
        private TextBox rad2ang_ang;
        private TextBox rad2ang_rad;
        private TextBox ang2dfm_dfm;
        private TextBox ang2dfm_ang;
        private Label label8;
        private Label label7;
        private Button ang2rad_new;
        private Button ang2rad_cal;
        private TextBox ang2rad_rad;
        private TextBox ang2rad_ang;
        private Label label12;
        private Label label11;
    }
}