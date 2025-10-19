using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class FormCoordinateCalculation : Form
    {
        private double inputNumber2, inputNumber3, inputNumber4, inputNumber5;
        public FormCoordinateCalculation()
        {
            InitializeComponent();
        }

        private void disAndang_knowX_KeyPress(object sender, KeyPressEventArgs e)
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

        private void disAndang_knowY_KeyPress(object sender, KeyPressEventArgs e)
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

        private void disAndang_dis_KeyPress(object sender, KeyPressEventArgs e)
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

        private void disAndang_ang_KeyPress(object sender, KeyPressEventArgs e)
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

        private void disAndang_cal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(disAndang_knowX.Text, out double tempNumber2))
            {
                MessageBox.Show("请先输入合法数据!");
                disAndang_knowX.Focus();
                return;
            }

            if (!double.TryParse(disAndang_knowY.Text, out double tempNumber3))
            {
                MessageBox.Show("请先输入合法数据!");
                disAndang_knowY.Focus();
                return;
            }

            if (!double.TryParse(disAndang_dis.Text, out double tempNumber4))
            {
                MessageBox.Show("请先输入合法数据!");
                disAndang_dis.Focus();
                return;
            }

            if (!double.TryParse(disAndang_ang.Text, out double tempNumber5))
            {
                MessageBox.Show("请先输入合法数据!");
                disAndang_ang.Focus();
                return;
            }
            point a = new point();
            a.x = tempNumber2;
            a.y = tempNumber3;
            inputNumber4 = tempNumber4;
            inputNumber5 = tempNumber5;
            point result = new point();
            result = coordinateCalculation.forwardCal(a, inputNumber4, inputNumber5);
            disAndang_needX.Text = $"{result.x:F10}";
            disAndang_needY.Text = $"{result.y:F10}";
        }

        private void disAndang_new_Click(object sender, EventArgs e)
        {
            disAndang_ang.Clear();
            disAndang_dis.Clear();
            disAndang_knowX.Clear();
            disAndang_knowY.Clear();
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
            point a = new point();
            point b = new point();
            a.x = tempNumber2;
            a.y = tempNumber3;
            b.x = tempNumber4;
            b.y = tempNumber5;
            double result = coordinateCalculation.Distance(a, b);
            dis.Text = $"{result}";
        }

        private void dis_new_Click(object sender, EventArgs e)
        {
            dis_x1.Clear();
            dis_y1.Clear();
            dis_x2.Clear();
            dis_y2.Clear();
            dis.Clear();
        }

        private void ang_x1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ang_y1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ang_x2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ang_y2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ang_cal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(ang_x1.Text, out double tempNumber2))
            {
                MessageBox.Show("请先输入合法数据!");
                ang_x1.Focus();
                return;
            }
            if (!double.TryParse(ang_y1.Text, out double tempNumber3))
            {
                MessageBox.Show("请先输入合法数据!");
                ang.Focus();
                return;
            }
            if (!double.TryParse(ang_x2.Text, out double tempNumber4))
            {
                MessageBox.Show("请先输入合法数据!");
                ang_x2.Focus();
                return;
            }
            if (!double.TryParse(ang_y2.Text, out double tempNumber5))
            {
                MessageBox.Show("请先输入合法数据!");
                ang_y2.Focus();
                return;
            }
            point a = new point();
            point b = new point();
            a.x = tempNumber2;
            a.y = tempNumber3;
            b.x = tempNumber4;
            b.y = tempNumber5;
            double result = coordinateCalculation.ang(a, b);
            ang.Text = $"{result}";
        }

        private void ang_new_Click(object sender, EventArgs e)
        {
            ang_x1.Clear();
            ang_y1.Clear();
            ang_x2.Clear();
            ang_y2.Clear();
            ang.Clear();
        }

    }

}
