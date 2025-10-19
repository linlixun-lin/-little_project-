namespace WinFormsApp4
{
    partial class FormCoordinateCalculation
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
            groupBox1 = new GroupBox();
            disAndang_new = new Button();
            disAndang_cal = new Button();
            disAndang_needY = new TextBox();
            disAndang_needX = new TextBox();
            disAndang_ang = new TextBox();
            disAndang_dis = new TextBox();
            disAndang_knowY = new TextBox();
            disAndang_knowX = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dis_new = new Button();
            dis_cal = new Button();
            dis = new TextBox();
            dis_y2 = new TextBox();
            dis_x2 = new TextBox();
            dis_y1 = new TextBox();
            dis_x1 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            ang_new = new Button();
            ang_cal = new Button();
            ang = new TextBox();
            label17 = new Label();
            label16 = new Label();
            ang_y2 = new TextBox();
            ang_x2 = new TextBox();
            ang_y1 = new TextBox();
            ang_x1 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(disAndang_new);
            groupBox1.Controls.Add(disAndang_cal);
            groupBox1.Controls.Add(disAndang_needY);
            groupBox1.Controls.Add(disAndang_needX);
            groupBox1.Controls.Add(disAndang_ang);
            groupBox1.Controls.Add(disAndang_dis);
            groupBox1.Controls.Add(disAndang_knowY);
            groupBox1.Controls.Add(disAndang_knowX);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 24);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(183, 387);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "计算待测点坐标";
            // 
            // disAndang_new
            // 
            disAndang_new.Location = new Point(30, 343);
            disAndang_new.Margin = new Padding(2, 3, 2, 3);
            disAndang_new.Name = "disAndang_new";
            disAndang_new.Size = new Size(73, 25);
            disAndang_new.TabIndex = 13;
            disAndang_new.Text = "重置";
            disAndang_new.UseVisualStyleBackColor = true;
            disAndang_new.Click += disAndang_new_Click;
            // 
            // disAndang_cal
            // 
            disAndang_cal.Location = new Point(30, 313);
            disAndang_cal.Margin = new Padding(2, 3, 2, 3);
            disAndang_cal.Name = "disAndang_cal";
            disAndang_cal.Size = new Size(73, 25);
            disAndang_cal.TabIndex = 12;
            disAndang_cal.Text = "计算";
            disAndang_cal.UseVisualStyleBackColor = true;
            disAndang_cal.Click += disAndang_cal_Click;
            // 
            // disAndang_needY
            // 
            disAndang_needY.Location = new Point(27, 270);
            disAndang_needY.Margin = new Padding(2, 3, 2, 3);
            disAndang_needY.Name = "disAndang_needY";
            disAndang_needY.ReadOnly = true;
            disAndang_needY.Size = new Size(98, 23);
            disAndang_needY.TabIndex = 11;
            // 
            // disAndang_needX
            // 
            disAndang_needX.Location = new Point(26, 215);
            disAndang_needX.Margin = new Padding(2, 3, 2, 3);
            disAndang_needX.Name = "disAndang_needX";
            disAndang_needX.ReadOnly = true;
            disAndang_needX.Size = new Size(98, 23);
            disAndang_needX.TabIndex = 10;
            // 
            // disAndang_ang
            // 
            disAndang_ang.Location = new Point(26, 170);
            disAndang_ang.Margin = new Padding(2, 3, 2, 3);
            disAndang_ang.Name = "disAndang_ang";
            disAndang_ang.Size = new Size(98, 23);
            disAndang_ang.TabIndex = 9;
            disAndang_ang.KeyPress += disAndang_ang_KeyPress;
            // 
            // disAndang_dis
            // 
            disAndang_dis.Location = new Point(26, 125);
            disAndang_dis.Margin = new Padding(2, 3, 2, 3);
            disAndang_dis.Name = "disAndang_dis";
            disAndang_dis.Size = new Size(98, 23);
            disAndang_dis.TabIndex = 8;
            disAndang_dis.KeyPress += disAndang_dis_KeyPress;
            // 
            // disAndang_knowY
            // 
            disAndang_knowY.Location = new Point(26, 80);
            disAndang_knowY.Margin = new Padding(2, 3, 2, 3);
            disAndang_knowY.Name = "disAndang_knowY";
            disAndang_knowY.Size = new Size(98, 23);
            disAndang_knowY.TabIndex = 7;
            disAndang_knowY.KeyPress += disAndang_knowY_KeyPress;
            // 
            // disAndang_knowX
            // 
            disAndang_knowX.Location = new Point(26, 44);
            disAndang_knowX.Margin = new Padding(2, 3, 2, 3);
            disAndang_knowX.Name = "disAndang_knowX";
            disAndang_knowX.Size = new Size(98, 23);
            disAndang_knowX.TabIndex = 6;
            disAndang_knowX.KeyPress += disAndang_knowX_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 251);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 17);
            label6.TabIndex = 5;
            label6.Text = "待求点Y坐标";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 196);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 17);
            label5.TabIndex = 4;
            label5.Text = "待求点X坐标";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 150);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(176, 17);
            label4.TabIndex = 3;
            label4.Text = "两点的方位角（请输入度分秒）";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 105);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 2;
            label3.Text = "两点之间的距离";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 1;
            label2.Text = "已知点Y坐标";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 0;
            label1.Text = "已知点X坐标";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dis_new);
            groupBox2.Controls.Add(dis_cal);
            groupBox2.Controls.Add(dis);
            groupBox2.Controls.Add(dis_y2);
            groupBox2.Controls.Add(dis_x2);
            groupBox2.Controls.Add(dis_y1);
            groupBox2.Controls.Add(dis_x1);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(278, 24);
            groupBox2.Margin = new Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 3, 2, 3);
            groupBox2.Size = new Size(183, 387);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "计算两点距离";
            // 
            // dis_new
            // 
            dis_new.Location = new Point(56, 343);
            dis_new.Margin = new Padding(2, 3, 2, 3);
            dis_new.Name = "dis_new";
            dis_new.Size = new Size(73, 25);
            dis_new.TabIndex = 11;
            dis_new.Text = "重置";
            dis_new.UseVisualStyleBackColor = true;
            dis_new.Click += dis_new_Click;
            // 
            // dis_cal
            // 
            dis_cal.Location = new Point(56, 313);
            dis_cal.Margin = new Padding(2, 3, 2, 3);
            dis_cal.Name = "dis_cal";
            dis_cal.Size = new Size(73, 25);
            dis_cal.TabIndex = 10;
            dis_cal.Text = "计算";
            dis_cal.UseVisualStyleBackColor = true;
            dis_cal.Click += dis_cal_Click;
            // 
            // dis
            // 
            dis.Location = new Point(40, 241);
            dis.Margin = new Padding(2, 3, 2, 3);
            dis.Name = "dis";
            dis.ReadOnly = true;
            dis.Size = new Size(98, 23);
            dis.TabIndex = 9;
            // 
            // dis_y2
            // 
            dis_y2.Location = new Point(39, 196);
            dis_y2.Margin = new Padding(2, 3, 2, 3);
            dis_y2.Name = "dis_y2";
            dis_y2.Size = new Size(98, 23);
            dis_y2.TabIndex = 8;
            dis_y2.KeyPress += dis_y2_KeyPress;
            // 
            // dis_x2
            // 
            dis_x2.Location = new Point(40, 150);
            dis_x2.Margin = new Padding(2, 3, 2, 3);
            dis_x2.Name = "dis_x2";
            dis_x2.Size = new Size(98, 23);
            dis_x2.TabIndex = 7;
            dis_x2.KeyPress += dis_x2_KeyPress;
            // 
            // dis_y1
            // 
            dis_y1.Location = new Point(40, 105);
            dis_y1.Margin = new Padding(2, 3, 2, 3);
            dis_y1.Name = "dis_y1";
            dis_y1.Size = new Size(98, 23);
            dis_y1.TabIndex = 6;
            dis_y1.KeyPress += dis_y1_KeyPress;
            // 
            // dis_x1
            // 
            dis_x1.Location = new Point(40, 70);
            dis_x1.Margin = new Padding(2, 3, 2, 3);
            dis_x1.Name = "dis_x1";
            dis_x1.Size = new Size(98, 23);
            dis_x1.TabIndex = 5;
            dis_x1.KeyPress += dis_x1_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 221);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(68, 17);
            label11.TabIndex = 4;
            label11.Text = "两点间距离";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 176);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(82, 17);
            label10.TabIndex = 3;
            label10.Text = "已知点2Y坐标";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 131);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(83, 17);
            label9.TabIndex = 2;
            label9.Text = "已知点2X坐标";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 91);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(82, 17);
            label8.TabIndex = 1;
            label8.Text = "已知点1Y坐标";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 50);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(83, 17);
            label7.TabIndex = 0;
            label7.Text = "已知点1X坐标";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ang_new);
            groupBox3.Controls.Add(ang_cal);
            groupBox3.Controls.Add(ang);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(ang_y2);
            groupBox3.Controls.Add(ang_x2);
            groupBox3.Controls.Add(ang_y1);
            groupBox3.Controls.Add(ang_x1);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label15);
            groupBox3.Location = new Point(531, 24);
            groupBox3.Margin = new Padding(2, 3, 2, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 3, 2, 3);
            groupBox3.Size = new Size(183, 387);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "计算两点方位角";
            // 
            // ang_new
            // 
            ang_new.Location = new Point(41, 343);
            ang_new.Margin = new Padding(2, 3, 2, 3);
            ang_new.Name = "ang_new";
            ang_new.Size = new Size(73, 25);
            ang_new.TabIndex = 21;
            ang_new.Text = "重置";
            ang_new.UseVisualStyleBackColor = true;
            ang_new.Click += ang_new_Click;
            // 
            // ang_cal
            // 
            ang_cal.Location = new Point(41, 313);
            ang_cal.Margin = new Padding(2, 3, 2, 3);
            ang_cal.Name = "ang_cal";
            ang_cal.Size = new Size(73, 25);
            ang_cal.TabIndex = 20;
            ang_cal.Text = "计算";
            ang_cal.UseVisualStyleBackColor = true;
            ang_cal.Click += ang_cal_Click;
            // 
            // ang
            // 
            ang.Location = new Point(32, 241);
            ang.Margin = new Padding(2, 3, 2, 3);
            ang.Name = "ang";
            ang.ReadOnly = true;
            ang.Size = new Size(98, 23);
            ang.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(32, 221);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(140, 17);
            label17.TabIndex = 18;
            label17.Text = "两点的方位角（弧度制）";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(34, 221);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(0, 17);
            label16.TabIndex = 17;
            // 
            // ang_y2
            // 
            ang_y2.Location = new Point(33, 196);
            ang_y2.Margin = new Padding(2, 3, 2, 3);
            ang_y2.Name = "ang_y2";
            ang_y2.Size = new Size(98, 23);
            ang_y2.TabIndex = 16;
            ang_y2.KeyPress += ang_y2_KeyPress;
            // 
            // ang_x2
            // 
            ang_x2.Location = new Point(33, 150);
            ang_x2.Margin = new Padding(2, 3, 2, 3);
            ang_x2.Name = "ang_x2";
            ang_x2.Size = new Size(98, 23);
            ang_x2.TabIndex = 15;
            ang_x2.KeyPress += ang_x2_KeyPress;
            // 
            // ang_y1
            // 
            ang_y1.Location = new Point(34, 105);
            ang_y1.Margin = new Padding(2, 3, 2, 3);
            ang_y1.Name = "ang_y1";
            ang_y1.Size = new Size(98, 23);
            ang_y1.TabIndex = 14;
            ang_y1.KeyPress += ang_y1_KeyPress;
            // 
            // ang_x1
            // 
            ang_x1.Location = new Point(34, 70);
            ang_x1.Margin = new Padding(2, 3, 2, 3);
            ang_x1.Name = "ang_x1";
            ang_x1.Size = new Size(98, 23);
            ang_x1.TabIndex = 13;
            ang_x1.KeyPress += ang_x1_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(32, 176);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(82, 17);
            label12.TabIndex = 12;
            label12.Text = "已知点2Y坐标";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(34, 131);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(83, 17);
            label13.TabIndex = 11;
            label13.Text = "已知点2X坐标";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 91);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(82, 17);
            label14.TabIndex = 10;
            label14.Text = "已知点1Y坐标";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(33, 50);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(83, 17);
            label15.TabIndex = 9;
            label15.Text = "已知点1X坐标";
            // 
            // FormCoordinateCalculation
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 436);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormCoordinateCalculation";
            Text = "坐标正反算";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button disAndang_new;
        private Button disAndang_cal;
        private TextBox disAndang_needY;
        private TextBox disAndang_needX;
        private TextBox disAndang_ang;
        private TextBox disAndang_dis;
        private TextBox disAndang_knowY;
        private TextBox disAndang_knowX;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox dis;
        private TextBox dis_y2;
        private TextBox dis_x2;
        private TextBox dis_y1;
        private TextBox dis_x1;
        private Label label11;
        private Button dis_new;
        private Button dis_cal;
        private Button ang_new;
        private Button ang_cal;
        private TextBox ang;
        private Label label17;
        private Label label16;
        private TextBox ang_y2;
        private TextBox ang_x2;
        private TextBox ang_y1;
        private TextBox ang_x1;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
    }
}