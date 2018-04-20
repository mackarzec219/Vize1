using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hak = 0, sayi_tahmin, randomsayi; 
        private void Form1_Load(object sender, EventArgs e) 
        {
            Random rnd = new Random(); 
            randomsayi = rnd.Next(0, 100); 

        }
        private void button1_Click(object sender, EventArgs e) 
        {
            if (textBox1.Text != "") 
            {
                if (hak < 10) 
                {
                    sayi_tahmin = int.Parse(textBox1.Text); 
                    if (sayi_tahmin < randomsayi) 
                    {
                        listBox1.Items.Add(sayi_tahmin); 
                        textBox1.Text = ""; 
                        hak++; 
                        label2.Text = "Girdiğiniz sayı tahmini sayıdan küçük.";
                    }
                    else if (sayi_tahmin > randomsayi)
                    {
                        listBox1.Items.Add(sayi_tahmin); 
                        textBox1.Text = ""; 
                        hak++; 
                        label2.Text = "Girdiğiniz sayı tahmini sayıdan büyük."; 
                    }
                    else if (sayi_tahmin == randomsayi) 
                        MessageBox.Show("Helal be Koçum! Doğru sayıyı bularak oyunu başarıyla tamamladınız.", "Tebrikler!"); 
                }
                else
                    MessageBox.Show("Kaybettiniz!", "Maalesef 10 hakkınızın tamamını kullandınız.");
            }
            else if (textBox1.Text == "") 
            {
                MessageBox.Show("Lütfen tahmin sayınızı giriniz."); 
            }
        }
    }
}
