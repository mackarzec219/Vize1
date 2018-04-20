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

        int hak = 0, tahmin_sayi, randomsayi; 
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
                    tahmin_sayi = int.Parse(textBox1.Text); 
                    if (tahmin_sayi < randomsayi) 
            {
                        listBox1.Items.Add(tahmin_sayi); 
                        textBox1.Text = ""; 
                        hak++; 
                        label2.Text = "Girilen sayı tahmin edilen sayıdan küçük.";
            }
                    else if (tahmin_sayi > randomsayi)
            {
                        listBox1.Items.Add(tahmin_sayi); 
                        textBox1.Text = ""; 
                        hak++; 
                        label2.Text = "Girilen sayı tahmin edilen sayıdan büyük."; 
            }
                    else if (tahmin_sayi == randomsayi) 
                        MessageBox.Show("Doğru sayıyı buldunuz.", "Tebrikler."); 
            }
                else
                    MessageBox.Show("Hakkınız bitti", "Maalesef haklarınızın hepsini kullandınız.");
            }
            else if (textBox1.Text == "") 
            {
                MessageBox.Show("Lütfen tahmin sayınızı giriniz."); 
            }
            }
            }
            }
