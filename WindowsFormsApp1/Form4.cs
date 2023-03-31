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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = float.Parse(textBox1.Text);
            switch (a)
            {
                case 6:
                    textBox2.Text = "Шестерка";
                    break;
                case 7:
                    textBox2.Text = "Семерка";
                    break;
                case 8:
                    textBox2.Text = "Восьмерка";
                    break;
                case 9:
                    textBox2.Text = "Девятка";
                    break;
                case 10:
                    textBox2.Text = "Десятка";
                    break;
                case 11:
                    textBox2.Text = "Валет";
                    break;
                case 12:
                    textBox2.Text = "Дама";
                    break;
                case 13:
                    textBox2.Text = "Король";
                    break;
                case 14:
                    textBox2.Text = "Туз";
                    break;
                default:
                    textBox2.Text = "Такой карты нет)";
                    break;
            }

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
    }
}
