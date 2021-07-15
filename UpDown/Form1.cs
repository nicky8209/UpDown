using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpDown
{
    public partial class Form1 : Form
    {
        private int x;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qwer = Convert.ToInt32(textBox1.Text);

            if (qwer > x)
            {
                MessageBox.Show("Down");
            }
            else if (qwer < x)
            {
                MessageBox.Show("Up");

            }
            else if (qwer == x)
            {
                MessageBox.Show("Win");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            x = r.Next(1, 100);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();

            x = r.Next(1, 100);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show(Convert.ToString(x));
            }
        }
    }
}
