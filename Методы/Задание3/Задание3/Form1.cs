using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.ReadOnly = true;
        }
        private double Ost(double a, double b)
        {
            return a % b;
        }
        private double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
        private string Concat(double a, double b)
        {
            return a.ToString() + b.ToString();
        }
        private double Div(double a, double b)
        {
            return a / b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double first = Convert.ToDouble(textBox1.Text);
                double second = Convert.ToDouble(textBox2.Text);

                if (radioButton1.Checked)
                {
                    textBox3.Text = Ost(first, second).ToString();
                }
                else if (radioButton2.Checked)
                {
                    textBox3.Text = Pow(first, second).ToString();
                }
                else if (radioButton3.Checked)
                {
                    textBox3.Text = Concat(first, second).ToString();
                }
                else if (radioButton4.Checked)
                {
                    textBox3.Text = Div(first, second).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
