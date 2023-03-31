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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form2();
            ifrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form3();
            ifrm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form4();
            ifrm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form5();
            ifrm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form6();
            ifrm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form7();
            ifrm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
