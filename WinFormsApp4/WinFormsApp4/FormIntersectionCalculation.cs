using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FormIntersectionCalculation : Form
    {
        private double ang1, ang2, ang3, distance1, distance2;
        public FormIntersectionCalculation()
        {
            InitializeComponent();
        }

        private void after_x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void after_y1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void after_x2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void after_y2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void after_x3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void after_y3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void after_ang1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void after_ang2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void after_ang3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void after_cal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(after_x1.Text, out double tempNumber2))
            {
                MessageBox.Show("请先输入合法数据!");
                after_x1.Focus();
                return;
            }
            if (!double.TryParse(after_y1.Text, out double tempNumber3))
            {
                MessageBox.Show("请先输入合法数据!");
                after_y1.Focus();
                return;
            }
            if (!double.TryParse(after_x2.Text, out double tempNumber4))
            {
                MessageBox.Show("请先输入合法数据!");
                after_x2.Focus();
                return;
            }
            if (!double.TryParse(after_y2.Text, out double tempNumber5))
            {
                MessageBox.Show("请先输入合法数据!");
                after_y2.Focus();
                return;
            }
            if (!double.TryParse(after_x3.Text, out double tempNumber6))
            {
                MessageBox.Show("请先输入合法数据!");
                after_x3.Focus();
                return;
            }
            if (!double.TryParse(after_y3.Text, out double tempNumber7))
            {
                MessageBox.Show("请先输入合法数据!");
                after_y3.Focus();
                return;
            }
            if (!double.TryParse(after_ang1.Text, out double tempNumber8))
            {
                MessageBox.Show("请先输入合法数据!");
                after_ang1.Focus();
                return;
            }
            if (!double.TryParse(after_ang2.Text, out double tempNumber9))
            {
                MessageBox.Show("请先输入合法数据!");
                after_ang2.Focus();
                return;
            }
            if (!double.TryParse(after_ang3.Text, out double tempNumber10))
            {
                MessageBox.Show("请先输入合法数据!");
                after_ang3.Focus();
                return;
            }
            point a = new point();
            point b = new point();
            point c = new point();
            a.x = tempNumber2;
            a.y = tempNumber3;
            b.x = tempNumber4;
            b.y = tempNumber5;
            c.x = tempNumber6;
            c.y = tempNumber7;
            ang1 = tempNumber8;
            ang2 = tempNumber9;
            ang3 = tempNumber10;
            point result = new point();
            result = intersectionCalculation.angAfter(a, b, c, ang1, ang2, ang3);
            after_needx.Text = $"{result.x}";
            after_needy.Text = $"{result.y}";
        }

        private void after_new_Click(object sender, EventArgs e)
        {
            after_x1.Clear();
            after_y1.Clear();
            after_ang1.Clear();
            after_ang2.Clear();
            after_ang3.Clear();
            after_x2.Clear();
            after_y2.Clear();
            after_x3.Clear();
            after_y3.Clear();
            after_needy.Clear();
            after_needx.Clear();
        }

        private void dis_x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dis_y1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dis_x2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dis_y2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dis1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dis2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }



        private void dis_cal_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(dis_x1.Text, out double tempNumber2))
            {
                MessageBox.Show("请先输入合法数据!");
                dis_x1.Focus();
                return;
            }
            if (!double.TryParse(dis_y1.Text, out double tempNumber3))
            {
                MessageBox.Show("请先输入合法数据!");
                dis_y1.Focus();
                return;
            }
            if (!double.TryParse(dis_x2.Text, out double tempNumber4))
            {
                MessageBox.Show("请先输入合法数据!");
                dis_x2.Focus();
                return;
            }
            if (!double.TryParse(dis_y2.Text, out double tempNumber5))
            {
                MessageBox.Show("请先输入合法数据!");
                dis_y2.Focus();
                return;
            }
            if (!double.TryParse(dis1.Text, out double tempNumber6))
            {
                MessageBox.Show("请先输入合法数据!");
                dis1.Focus();
                return;
            }
            if (!double.TryParse(dis2.Text, out double tempNumber7))
            {
                MessageBox.Show("请先输入合法数据!");
                dis2.Focus();
                return;
            }
            point a = new point();
            point b = new point();
            a.x = tempNumber2;
            a.y = tempNumber3;
            b.x = tempNumber4;
            b.y = tempNumber5;
            point result = new point();
            distance1 = tempNumber6;
            distance2 = tempNumber7;
            result = intersectionCalculation.angDis(a, b, distance1, distance2);

            dis_needx.Text = $"{result.x}";
            dis_needy.Text = $"{result.y}";

        }


        private void ahead_x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ahead_y1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ahead_x2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ahead_y2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ahead_ang1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ahead_ang2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && ((System.Windows.Forms.TextBox)sender).Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ahead_cal_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(ahead_x1.Text, out double tempNumber2))
            {
                MessageBox.Show("请先输入合法数据!");
                ahead_x1.Focus();
                return;
            }
            if (!double.TryParse(ahead_y1.Text, out double tempNumber3))
            {
                MessageBox.Show("请先输入合法数据!");
                ahead_y1.Focus();
                return;
            }
            if (!double.TryParse(ahead_x2.Text, out double tempNumber4))
            {
                MessageBox.Show("请先输入合法数据!");
                ahead_x2.Focus();
                return;
            }
            if (!double.TryParse(ahead_y2.Text, out double tempNumber5))
            {
                MessageBox.Show("请先输入合法数据!");
                ahead_y2.Focus();
                return;
            }
            if (!double.TryParse(ahead_ang1.Text, out double tempNumber6))
            {
                MessageBox.Show("请先输入合法数据!");
                ahead_ang1.Focus();
                return;
            }
            if (!double.TryParse(ahead_ang2.Text, out double tempNumber7))
            {
                MessageBox.Show("请先输入合法数据!");
                ahead_ang2.Focus();
                return;
            }
            point a = new point();
            point b = new point();
            a.x = tempNumber2;
            a.y = tempNumber3;
            b.x = tempNumber4;
            b.y = tempNumber5;
            point result = new point();
            ang1 = tempNumber6;
            ang2 = tempNumber7;
            result = intersectionCalculation.angAhead(a, b, ang1, ang2);

            ahead_needx.Text = $"{result.x}";
            ahead_needy.Text = $"{result.y}";

        }

        private void dis_new_Click(object sender, EventArgs e)
        {
            dis_x1.Clear();
            dis_y1.Clear();
            dis_x2.Clear();
            dis_y2.Clear();
            dis1.Clear();
            dis2.Clear();
            dis_needx.Clear();
            dis_needy.Clear();
        }

        private void ahead_new_Click(object sender, EventArgs e)
        {
            ahead_x1.Clear();
            ahead_y1.Clear();
            ahead_x2.Clear();
            ahead_y2.Clear();
            ahead_needx.Clear();
            ahead_needy.Clear();
            ahead_ang1.Clear();
            ahead_ang2.Clear();
        }
    }
}
