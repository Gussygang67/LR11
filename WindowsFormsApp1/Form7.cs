using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, h;
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                h = double.Parse(textBox3.Text);
                double y;
                int i = 1;
                listBox1.Items.Clear();
                listBox1.Items.Add("#   " + "x   " + "f(x) ");
                for (double x = a; x <= b; x += h, ++i)
                {
                    if (x >= 0.9)
                    {
                        y = 1/(Math.Pow(0.1+x,2));
                    }
                    else if (x >= 0 && x < 0.9)
                    {
                        y = 0.2*x + 0.1;
                    }
                    else
                    {
                        y = Math.Pow(x,2) + 0.2;
                    }
                    x = Math.Round(x, 6);
                    listBox1.Items.Add(i + "   " + x + "   " + Math.Round(y, 6));
                }
                if (a > b)
                {
                    MessageBox.Show("a должно быть меньше b", "Что-то пошло не так!");
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }
    }
}
