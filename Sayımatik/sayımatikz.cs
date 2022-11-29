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
    public partial class sayımatikz : Form
    {
        public sayımatikz()
        {
            InitializeComponent();
        }

        Random islemrnd = new Random();

        Random rnd = new Random();
        int sayi1, sayi2, cevap, sure, dogru;

        char islem;

        private void sayımatikz_Load(object sender, EventArgs e)
        {
            sure = 4;
            uret();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yeniOyun();
            uret();
            textBox1.Text = "";
            
        }

        void uret()
        {
            //toplama çıkarma (1-150) arası
            //çarpma bölme (1-25) arası +(bölmede s1>s2 olacak)

            islem = (char)islemrnd.Next(0, 4);
            if (islem == 0) //(Toplama)
            {
                sayi1 = rnd.Next(1, 150);
                sayi2 = rnd.Next(1, 150);
                labels1.Text = sayi1.ToString() + " + " + sayi2.ToString() + " = ";
                cevap = sayi1 + sayi2;
            }
            if (islem == 1) //(Çıkarma)
            {
                sayi1 = rnd.Next(1, 150);
                sayi2 = rnd.Next(1, 150);
                labels1.Text = sayi1.ToString() + " - " + sayi2.ToString() + " = ";
                cevap = sayi1 - sayi2;
            }
            if (islem == 2) //(Çarpma)
            {
                sayi1 = rnd.Next(1, 25);
                sayi2 = rnd.Next(1, 25);
                labels1.Text = sayi1.ToString() + " * " + sayi2.ToString() + " = ";
                cevap = sayi1 * sayi2;
            }
            if (islem == 3 && sayi1 > sayi2) //(Bölme)
            {
                sayi1 = rnd.Next(1, 25);
                sayi2 = rnd.Next(1, 25);
                labels1.Text = sayi1.ToString() + " / " + sayi2.ToString() + " = ";
                cevap = sayi1 / sayi2;
                //tam sayı kısmını girsin yeter.
            }

        }

        void oyunBitti()
        {
            timer1.Stop();
            button2.Visible = true;
            label2.Text = "Süre doldu";
            label3.Visible = false;
            label4.Visible = true;
            this.BackColor = Color.Red;
            dogru = 0;
            sure = 4;
            button1.Enabled = false;
            label1.Text = "Doğru Cevap : " + cevap;
            label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
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

        void yeniOyun()
        {
            timer1.Start();

            button2.Visible = false;
            label2.Text = "Kalan Süre : " + sure.ToString();
            label3.Text = "Doğru Sayısı : " + dogru.ToString();
            label3.Visible = true;
            this.BackColor = Color.Yellow;
            button1.Enabled = true;
            label4.Visible = false;
            label1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sure != 0)
            {
                sure--;
                label2.Text = "Kalan Süre : " + sure.ToString();
                label3.Text = "Doğru Sayısı : " + dogru.ToString();
                label4.Text = "Skorunuz :" + dogru.ToString();
                this.BackColor = Color.Yellow;
            }
            else
            {              
                oyunBitti();
            }
        }
        
    }
}
