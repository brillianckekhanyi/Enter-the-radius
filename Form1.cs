using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enter_the_radius
{
    public partial class Form1 : Form
    {
        //public double area;
        //public double pi = 3.14;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double area, radius;
            if (double.TryParse(textBox1.Text, out radius))
            {
                area = Math.PI * Math.Pow(radius, 2);
                textBox2.Text = area.ToString("F2");

            }
            else
            {
                MessageBox.Show("enter the valid number");
            }


        }
    }
}