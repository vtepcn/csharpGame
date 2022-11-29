using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayımatik
{
    public partial class sayımatiko : Form
    {
        public sayımatiko()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sayi1, sayi2, cevap, sure, dogru;

        private void button2_Click(object sender, EventArgs e)
        {
            yeniOyun();
            uret();
            textBox1.Text = "";
        }

        void uret()
        {
            sayi1 = rnd.Next(1, 100);
            sayi2 = rnd.Next(1, 100);
            cevap = sayi1 + sayi2;
            label1.Text = sayi1.ToString() + " + " + sayi2.ToString() + " = ";
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş değer girdiniz!");
            }

            else
            {
                int girilenSayi = Convert.ToInt32(textBox1.Text);
                if (girilenSayi == cevap)
                {
                    dogru++;
                    this.BackColor = Color.Green;
                    uret();
                    textBox1.Text = "";
                    sure = 4;
                }
                else
                {
                    oyunBitti();
                }
            }
        }

        void oyunBitti()
        {
            timer1.Stop();
            button2.Visible = true;
            label2.Text = "Oyun Bitti";
            label3.Visible = false;
            label4.Visible = true;
            this.BackColor = Color.Red;
            dogru = 0;
            sure = 4;
            button1.Enabled = false;
            label5.Text = "Doğru Cevap : " + cevap;
            label5.Visible = true;
        }
        void yeniOyun()
        {
            timer1.Start();

            button2.Visible = false;
            label2.Text = "Kalan Süre : " + sure.ToString();
            label3.Text = "Doğru Sayısı : " + dogru.ToString();
            label3.Visible = true;
            this.BackColor = Color.Blue;
            button1.Enabled = true;
            label4.Visible = false;
            label5.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sure != 0)
            {
                sure--;
                label2.Text = "Kalan Süre : " + sure.ToString();
                label3.Text = "Doğru Sayısı : " + dogru.ToString();
                label4.Text = "Skorunuz :" + dogru.ToString();
                this.BackColor = Color.Blue;
            }
            else
            {
                oyunBitti();
            }
        }

        private void sayımatiko_Load(object sender, EventArgs e)
        {
            sure = 4;
            uret();
            timer1.Start();
        }
    }
}
