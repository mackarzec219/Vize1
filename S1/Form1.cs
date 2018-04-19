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

        int hak = 0, sayi_tahmin, randomsayi; // Değişkenler tanımlandı
        private void Form1_Load(object sender, EventArgs e) // Random sayı aldırma
        {
            Random rnd = new Random(); // Random sayi bir değişkene atandı.
            randomsayi = rnd.Next(0, 100); // 0-100 arasında alınan random değer sayi değişkenine aktarıldı

        }
        private void button1_Click(object sender, EventArgs e) // Butona tıklandıktan sonra olucak olan işlemler
        {
            if (textBox1.Text != "") // textBox1 ın boş mu bolumu onu kontrol ediyoruz.
            {
                if (hak < 10) // Eğer hak 10'dan küçükse (0-10 arasında 10 dahil değil)
                {
                    sayi_tahmin = int.Parse(textBox1.Text); // textBox1'e girilen sayıyı tahmini_Sayi değişkenine atadık
                    if (sayi_tahmin < randomsayi) // Eğer tahmin sayımız random sayıdan küçükse
                    {
                        listBox1.Items.Add(sayi_tahmin); // Tahmini sayıyı listBox1'e ekle
                        textBox1.Text = ""; // textBox1'in içini temizle
                        hak++; // Hakkı 1 arttır
                        label2.Text = "Girdiğiniz sayı tahmini sayıdan küçük."; // label2'ye uyarı yazdır
                    }
                    else if (sayi_tahmin > randomsayi) // Eğer tahmin sayımız random sayıdan büyükse
                    {
                        listBox1.Items.Add(sayi_tahmin); // Tahmini sayıyı listBox1'e ekle
                        textBox1.Text = ""; // textBox1'in içini temizle
                        hak++; // Hakkı 1 arttır
                        label2.Text = "Girdiğiniz sayı tahmini sayıdan büyük."; // label2'ye uyarı yazdır
                    }
                    else if (sayi_tahmin == randomsayi) // Eğer tahmin sayımız random sayıya eşitse
                        MessageBox.Show("Helal be Koçum! Doğru sayıyı bularak oyunu başarıyla tamamladınız.", "Tebrikler!"); // Tebrik mesajı göster
                }
                else
                    MessageBox.Show("Kaybettiniz!", "Maalesef 10 hakkınızın tamamını kullandınız.");
            }
            else if (textBox1.Text == "") // textBox1'in dolu olup olmadığını kontrol ediyoruz
            {
                MessageBox.Show("Lütfen tahmin sayınızı giriniz."); // textBox1 boş ise uyarı mesajı ver
            }
        }
    }
}
