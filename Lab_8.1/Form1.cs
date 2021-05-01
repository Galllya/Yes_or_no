using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8._1
{
    public partial class Form1 : Form
    {
        double p = 0.5;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double a = rand.NextDouble();
            if (a < p) {
                button2.Visible = true;
                button2.Text = "ДА";
            }
            else
            {
                button2.Visible = true;
                button2.Text = "НЕТ";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
