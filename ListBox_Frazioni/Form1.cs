using Frazioni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListBox_Frazioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Fraction f1 = Fraction.Parse(textBox1.Text);
            Fraction f2 = Fraction.Parse(textBox2.Text);
            label1.Text = (f1 + f2).ToString();
            textBox1.Text = f1.ToString();
            textBox2.Text = f2.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(Fraction.Parse(textBox3.Text));
            textBox3.Clear();
            textBox3.Focus();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Fraction ftot = new Fraction(0,1);
            foreach (Fraction item in listBox1.Items)
            {
                ftot = ftot.Somma(item); 
            }
            label2.Text = ftot.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fraction f2 = Fraction.Parse(textBox3.Text);
                if (listBox1.Items.Contains(f2))
                {
                    listBox1.Items.RemoveAt(listBox1.Items.IndexOf(f2));
                }

                else
                {
                    MessageBox.Show("La frazione inserita non è presente nella lista");
                }
                textBox3.Clear();           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fraction f1 = Fraction.Parse(textBox1.Text);
            Fraction f2 = Fraction.Parse(textBox2.Text);
            label1.Text = (f1 - f2).ToString();
            textBox1.Text = f1.ToString();
            textBox2.Text = f2.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fraction f1 = Fraction.Parse(textBox1.Text);
            Fraction f2 = Fraction.Parse(textBox2.Text);
            label1.Text = (f1 * f2).ToString();
            textBox1.Text = f1.ToString();
            textBox2.Text = f2.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Fraction f1 = Fraction.Parse(textBox1.Text);
            Fraction f2 = Fraction.Parse(textBox2.Text);
            label1.Text = (f1 / f2).ToString();
            textBox1.Text = f1.ToString();
            textBox2.Text = f2.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Fraction f = Fraction.Parse(label1.Text);
            label1.Text = (-f).ToString();
        }
    }
}
