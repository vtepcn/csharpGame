using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Boş sayı giridiniz!");
            } 
            else
            {
                double sayi1, sayi2, topla, cikar, carp, bolme;
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);

                if (comboBox1.SelectedIndex == 0 || comboBox1.Text == "+")
                {
                    topla = sayi1 + sayi2;
                    label1.Text = topla.ToString();
                }
                if (comboBox1.SelectedIndex == 1 || comboBox1.Text == "-")
                {
                    carp = sayi1 - sayi2;
                    label1.Text = carp.ToString();
                }
                if (comboBox1.SelectedIndex == 2 || comboBox1.Text == "*")
                {
                    carp = sayi1 * sayi2;
                    label1.Text = carp.ToString();
                }
                if (comboBox1.SelectedIndex == 3 || comboBox1.Text == "/")
                {
                    bolme = sayi1 / sayi2;
                    label1.Text = bolme.ToString();
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "0";
        }
    }
}
