using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class FormAngleConversionCalculator : Form
    {
        private double inputNumber1;
        public FormAngleConversionCalculator()
        {
            InitializeComponent();
        }

        private void rad2dfm_rad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-'   )
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

        private void rad2dfm_cal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(rad2dfm_rad.Text, out double tempNumber1))
            {
                MessageBox.Show("请先输入合法数据!");
                rad2dfm_rad.Focus();
                return;
            }
            inputNumber1 = tempNumber1;
            double result;
            result = angleConversionCalculator.rad2dfm(inputNumber1);
            rad2dfm_dfm.Text = $"{result:F10}";
        }

        private void rad2dfm_new_Click(object sender, EventArgs e)
        {
            rad2dfm_dfm.Clear();
            rad2dfm_rad.Clear();
        }

        private void dfm2rad_dfm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dfm2rad_cal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(dfm2rad_dfm.Text, out double tempNumber1))
            {
                MessageBox.Show("请先输入合法数据!");
                dfm2rad_dfm.Focus();
                return;
            }
            inputNumber1 = tempNumber1;
            double result;
            result = angleConversionCalculator.dfm2rad(inputNumber1);
            dfm2rad_rad.Text = $"{result:F10}";
        }

        private void dfm2rad_new_Click(object sender, EventArgs e)
        {
            dfm2rad_dfm.Clear();
            dfm2rad_rad.Clear();
        }

        private void dfm2ang_dfm_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dfm2ang_cal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(dfm2ang_dfm.Text, out double tempNumber1))
            {
                MessageBox.Show("请先输入合法数据!");
                dfm2ang_dfm.Focus();
                return;
            }
            inputNumber1 = tempNumber1;
            double result;
            result = angleConversionCalculator.dfm2ang(inputNumber1);
            dfm2ang_ang.Text = $"{result:F10}";
        }

        private void dfm2ang_new_Click(object sender, EventArgs e)
        {
            dfm2ang_dfm.Clear();
            dfm2ang_ang.Clear();
        }

        private void ang2dfm_ang_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ang2dfm_cal_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(ang2dfm_ang.Text, out double tempNumber1))
            {
                MessageBox.Show("请先输入合法数据!");
                ang2dfm_ang.Focus();
                return;
            }
            inputNumber1 = tempNumber1;
            double result;
            result = angleConversionCalculator.ang2dfm(inputNumber1);
            ang2dfm_dfm.Text = $"{result:F10}";
        }

        private void ang2dfm_new_Click(object sender, EventArgs e)
        {
            ang2dfm_ang.Clear();
            ang2dfm_dfm.Clear();
        }

        private void rad2ang_rad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void rad2ang_cal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(rad2ang_rad.Text, out double tempNumber1))
            {
                MessageBox.Show("请先输入合法数据!");
                rad2ang_rad.Focus();
                return;
            }
            inputNumber1 = tempNumber1;
            double result;
            result = angleConversionCalculator.rad2ang(inputNumber1);
            rad2ang_ang.Text = $"{result:F10}";
        }

        private void rad2ang_new_Click(object sender, EventArgs e)
        {
            rad2ang_rad.Clear();
            rad2ang_ang.Clear();
        }

        private void ang2rad_ang_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ang2rad_cal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(ang2rad_ang.Text, out double tempNumber1))
            {
                MessageBox.Show("请先输入合法数据!");
                ang2rad_ang.Focus();
                return;
            }
            inputNumber1 = tempNumber1;
            double result;
            result = angleConversionCalculator.ang2rad(inputNumber1);
            ang2rad_rad.Text = $"{result:F10}";
        }

        private void ang2rad_new_Click(object sender, EventArgs e)
        {
            ang2rad_ang.Clear();
            ang2rad_rad.Clear();
        }
    }
}
