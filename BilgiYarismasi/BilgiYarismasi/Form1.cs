using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0;
        int dogruCevap = 0;
        int yanlisCevap = 0;

        int sure=20;

        private void button5_Click(object sender, EventArgs e)
        {
            btnBasla.Enabled = false;
            timer1.Enabled = true;
            sure = 20;
            label10.Text = sure.ToString();

            btnA.Enabled = Enabled;
            btnB.Enabled = Enabled;
            btnC.Enabled = Enabled;
            btnD.Enabled = Enabled;
            btnBasla.Text = "İleri";
            soruNo++;
            label1.Text = soruNo.ToString();

            if(soruNo == 1)
            {
                richTextBox1.Text = "Mustafa Kemal Atatürk kaç yılında doğmuştur ?";
                btnA.Text = "1880";
                btnB.Text = "1991";
                btnC.Text = "1881";
                btnD.Text = "1891";
                label4.Text = "1881";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Şirinler adlı çizgi filmde hangi adla bilinen şirinin kolunda kırmızı bir kalp vardır?";
                btnA.Text = "Obur Şirin";
                btnB.Text = "Şair Şirin";
                btnC.Text = "Şirine";
                btnD.Text = "Güçlü Şirin";
                label4.Text = "Güçlü Şirin";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Saçını başının üst bölümünde toplayıp dibinden bağlayarak at kuyruğu şeklinde aşağıya sarkıtan biri hangi saç biçimini yapmış olur?";
                btnA.Text = "Topuz";
                btnB.Text = "Kakül";
                btnC.Text = "Rasta";
                btnD.Text = "Atkuyruğu";
                label4.Text = "Atkuyruğu";
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Deyime göre, öğrenim görmüş, kültürlü kişiler ne yalamıştır?";
                btnA.Text = "Dondurma";
                btnB.Text = "Horoz şekeri";
                btnC.Text = "Limon";
                btnD.Text = "Mürekkep";
                label4.Text = "Mürekkep";
            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "1+1+1+1+1+1+1+1+1+1+1+1+1+1+1 işleminin sonucu kaçtır?";
                btnA.Text = "11";
                btnB.Text = "111";
                btnC.Text = "5";
                btnD.Text = "15";
                label4.Text = "15";
            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Kendi adını taşıyan çizgi filmde Kaptan Tsubasa, Japonya'nın hangi spor dalında mücadele eden milli takımlarında boy gösterir?";
                btnA.Text = "Körling";
                btnB.Text = "Su topu";
                btnC.Text = "Futbol";
                btnD.Text = "Yağlı güreş";
                label4.Text = "Futbol";
            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "Hangisi hayvanlar aleminin sürüngenler sınıfından değildir?";
                btnA.Text = "Yılanlar";
                btnB.Text = "Kertenkeleler";
                btnC.Text = "Kurbağalar";
                btnD.Text = "Kaplumbağalar";
                label4.Text = "Kaplumbağalar";
            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Bulunduğu yerde, orada yaşayanları rahatsız etme pahasına sürekli kalıp oraya yerleşen biri ne yapmış olur?";
                btnA.Text = "Kreplenmiş";
                btnB.Text = "Pastalanmış";
                btnC.Text = "Çöreklenmiş";
                btnD.Text = "Böreklenmiş";
                label4.Text = "Çöreklenmiş";
            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "5 makinenin 5 cihaz üretmesi 5 dakika sürüyorsa 100 makinenin 100 cihaz üretmesi ne kadar sürer?";
                btnA.Text = "5 dakika";
                btnB.Text = "25 dakika";
                btnC.Text = "1 saat";
                btnD.Text = "1 saat 40 dakika";
                label4.Text = "1 saat 40 dakika";
            }
            if (soruNo == 10)
            {
                btnBasla.Visible = false;
                btnBasla.Enabled = false;
                richTextBox1.Text = "DUS'a girecek olan biri hangi fakülteden mezun olmuştur?";
                btnA.Text = "Hukuk";
                btnB.Text = "Diş Hekimliği";
                btnC.Text = "Spor Bilimleri";
                btnD.Text = "Denizcilik";
                label4.Text = "Diş Hekimliği";                               
            }
           
            
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label3.Text = btnA.Text;
            if (label3.Text == label4.Text)
            {
                MessageBox.Show("Cevabınız Doğru");
                dogruCevap++;
                label5.Text = dogruCevap.ToString();
            }
            else
            {
                yanlisCevap++;
                label7.Text = yanlisCevap.ToString();
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnBasla.Enabled = true;
            timer1.Enabled = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label3.Text = btnB.Text;
            if (label3.Text == label4.Text)
            {
                MessageBox.Show("Cevabınız Doğru");
                dogruCevap++;
                label5.Text = dogruCevap.ToString();

            }
            else
            {
                yanlisCevap++;
                label7.Text = yanlisCevap.ToString();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnBasla.Enabled = true;
            timer1.Enabled = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label3.Text = btnC.Text;
            if (label3.Text == label4.Text)
            {
                MessageBox.Show("Cevabınız Doğru");
                dogruCevap++;
                label5.Text = dogruCevap.ToString();

            }
            else
            {
                yanlisCevap++;
                label7.Text = yanlisCevap.ToString();
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnBasla.Enabled = true;
            timer1.Enabled = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            label3.Text = btnD.Text;
            if (label3.Text == label4.Text)
            {
                MessageBox.Show("Cevabınız Doğru");
                dogruCevap++;
                label5.Text = dogruCevap.ToString();

            }
            else
            {
                yanlisCevap++;
                label7.Text = yanlisCevap.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = Convert.ToInt32(label10.Text);

            sure = sure - 1;
            label10.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Enabled = false;
                yanlisCevap++;
                label7.Text = yanlisCevap.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
    }
}
