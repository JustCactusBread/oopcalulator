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
        public string D;
        public string c1;
        public double r1,r2,res;
        public bool empt;
        public Form1()
        {
            empt = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            r1 = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(r1);
            textBox1.Text = res.ToString();
            empt = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (empt)
            {
                empt = false;
                textBox1.Text = "0";
            }
           
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else textBox1.Text += B.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            r1 = Convert.ToDouble(textBox1.Text);
            res = r1*r1;
            textBox1.Text = res.ToString();
            empt = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            r1 = Convert.ToDouble(textBox1.Text);
            res = 1/r1;
            textBox1.Text = res.ToString();
            empt = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            r1 = Convert.ToDouble(textBox1.Text);
            res = -r1;
            textBox1.Text = res.ToString();
            empt = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length - 1 == 0) 
                textBox1.Text = "0";
            else 
                textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length - 1);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (!textBox1.Text.Contains(",")) 
            textBox1.Text += B.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            c1 = textBox1.Text;
            empt = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            r1 = Convert.ToDouble(c1);
            r2 = Convert.ToDouble(textBox1.Text);
            switch (D)
            {
                case "+": res = r1 + r2; break;
                case "–": res = r1 - r2; break;
                case "×": res = r1 * r2; break;
                case "/": res = r1 / r2; break;
                case "%": res = r1*r2/100; break;

            }
            D = "=";
            empt = true;
            textBox1.Text = res.ToString();
        }
    }
}
