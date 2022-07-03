﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ex2
{
    class Presenter
    {
        private readonly Model model;
        private readonly MainWindow view;
        int s;

        public Presenter(MainWindow v)
        {
            model = new Model();
            view = v;
            view.Equal += view_Equal;

        }

        void view_Equal(object sender, EventArgs e)
        {
            try
            {
                model.label1 = Convert.ToString(view.label1.Content);

                double k = Convert.ToDouble(view.textBox1.Text);
                double t = Convert.ToDouble(view.textBox2.Text);
                view.textBox3.Text = model.Equal(k, t).ToString();
                view.label2.Content = "=".ToString();
            }
            catch
            {
                MessageBox.Show("Введите числовые значения");
            }
            
        }

    }
}
