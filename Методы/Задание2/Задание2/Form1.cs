﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Factorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox1.Text);
            label2.Text = "Количество возможных вариантов: " + Factorial(c);
        }
    }
}
