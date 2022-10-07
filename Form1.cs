using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace massIndex
{
    public partial class bmiCalc : Form
    {
        public bmiCalc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtHeight.Text == "" || txtWeight.Text == "")
            {
                MessageBox.Show("Unassigned Value", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtHeight.Clear();
                txtWeight.Clear();
                txtWeight.Focus();
            }

            else
            {
                try
                {
                    double w = Convert.ToDouble(txtWeight.Text);
                    double h = Convert.ToDouble(txtHeight.Text);

                    if (txtHeight.Text.Contains(".")) MessageBox.Show("Please use Comma (,) instead of Dot (.)", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (w <= 0 || h <= 0)
                    {
                        MessageBox.Show("Body Weight and Height could not be negative or zero!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        Application.Exit();
                    }

                    if (h > 10) txtMI.Text = Convert.ToString(w / Math.Pow(h, 2) * 10000);
                    else txtMI.Text = Convert.ToString(w / (Math.Pow(h, 2)));

                    double status = Convert.ToDouble(txtMI.Text);

                    if (status < 18.5)
                    {
                        txtStatus.Text = "Underwight";
                    }

                    else if (status >= 18.5 && status < 25)
                    {
                        txtStatus.Text = "Normal weight";
                    }

                    else if (status >= 25 && status < 30)
                    {
                        txtStatus.Text = "Overweight";
                    }

                    else if (status >= 30 && status < 35)
                    {
                        txtStatus.Text = "Obesity class I";
                    }

                    else if (status >= 35 && status < 40)
                    {
                        txtStatus.Text = "Obesity class II";
                    }

                    else if (status >= 40)
                    {
                        txtStatus.Text = "Obesity class III";
                    }
                }
                catch
                {
                    txtHeight.Clear();
                    txtWeight.Clear();
                    MessageBox.Show("Exception has occured", "Exception error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtWeight.Clear();
            txtWeight.Focus();
        }

        #region useless part
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bmiCalc_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
