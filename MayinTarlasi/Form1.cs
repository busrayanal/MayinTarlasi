using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* !!!READ ME!!!
 * Bu oyunda bazı kodları aynı şekilde tekrar tekrar yazdım, özellikle buton hareketleri ve mayın kontrolü.
 * Normalde bunu fonksiyonlarla çok daha kısa yazabilirdim ama ben mantığı iyice anlamak için
 * her adımı açık açık yazmayı tercih ettim.
 * Nuget paketlerini GUI arayüz tasarımı için kullandım.(Guna.UI)
 */

namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 0;// Oyunda geçen toplam süreyi saniye cinsinden tutması için.
        bool timerBasladi = false;// Zamanlayıcının başlayıp başlamadığını kontrol eder

        // 20x20 boyutunda oyun alanını temsil eden PictureBox dizisi
        PictureBox[,] hucreler = new PictureBox[20, 20];
        
        int oyuncuX = 0;// Oyuncunun oyun alanındaki X (satır) konumu
        int oyuncuY = 0;// Oyuncunun oyun alanındaki Y (sütun) konumu
        
        // Oyunun aktif olup olmadığını kontrol eden değişken
        bool oyunBasladi = false;

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // 20x20 boyutunda oyun alanı oluşturdum.
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    // Her hücre için yeni bir PictureBox oluşturdum.
                    PictureBox pb = new PictureBox();
                    // Hücrelerin genişlik ve yükseklik değerleri
                    pb.Width = 20;
                    pb.Height = 20;
                    // Hücrelerin panel üzerindeki konumları ayarları
                    pb.Left = j * 20;
                    pb.Top = i * 20;

                    pb.BackColor = Color.LightSkyBlue;
                    pb.BorderStyle = BorderStyle.FixedSingle;

                    // Oluşturulan hücre panel içerisine eklenir
                    panelOyun.Controls.Add(pb);
                    hucreler[i, j] = pb; // Hücre dizisine ilgili PictureBox atanır
                }
            }
        }

        // Oyunu başlangıç durumuna getiren metot. Oyun bittiğinde veya yeni oyun başlatıldığında çağrılır
        void OyunuSifirla()
        {
            // Zamanlayıcı durdurulur ve süre sıfırlanır
            timer1.Stop();
            saniye = 0;
            timerBasladi = false;
            lblZaman.Text = "Süre: 00:00";

            // Oyun alanındaki tüm hücreler temizlenir
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    mayinVar[i, j] = false; // Tüm mayın bilgileri sıfırlanır
                    hucreler[i, j].BackColor = Color.LightSkyBlue; // Hücrelerin rengi başlangıç rengine getirilir
                    hucreler[i, j].Image = null; // Önceki oyundan kalan görseller temizlenir  
                }
            }

            // Oyuncunun başlangıç konumu ayarlanır
            oyuncuX = 0;
            oyuncuY = 0;
            // Oyuncunun başlangıç hücresi sarı renkle gösterilir
            hucreler[0, 0].BackColor = Color.Yellow;
            // Yakındaki mayın sayısı etiketi sıfırlanır
            lblMayinYakin.Text = "Mayınlara Yakın: 0";
            // Oyun aktif hale getirilir
            oyunBasladi = true;

            // Seçili zorluk seviyesine göre yerleştirilecek mayın sayısı belirlenir
            int mayinSayisi = 40; // Varsayılan: Kolay seviye
            if (rbOrta.Checked) mayinSayisi = 50;
            if (rbZor.Checked) mayinSayisi = 80;
            // Belirlenen sayıda mayın rastgele yerleştirilir
            int yerlesen = 0;
            while (yerlesen < mayinSayisi)
            {
                // Rastgele hücre koordinatları üretilir
                int x = rnd.Next(0, 20);
                int y = rnd.Next(0, 20);
                
                // Aynı hücreye tekrar mayın konulmaması
                // ve başlangıç hücresine (0,0) mayın yerleştirilmemesi kontrol edilir
                if (!mayinVar[x, y] && !(x == 0 && y == 0))
                {
                    mayinVar[x, y] = true;
                    yerlesen++;
                }
            }
        }

        // Oyun alanındaki mayınların konumlarını tutan 20x20 boyutunda boolean dizi
        // true  -> hücrede mayın var
        // false -> hücrede mayın yok
        bool[,] mayinVar = new bool[20, 20];
        Random rnd = new Random();

        // Kolay seviye seçildiğinde çalışan olay metodu
        // Bu seviyede oyun alanına 40 adet mayın yerleştirilir
        private void rbKolay_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbKolay.Checked) return;

            // Temizle
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    // Önceki mayın bilgileri temizlenir
                    mayinVar[i, j] = false;
                    hucreler[i, j].BackColor = Color.LightSkyBlue;
                    hucreler[i, j].Image = null;
                }
            }

            int yerlesen = 0;
            // 40 adet mayın rastgele hücrelere yerleştirilir
            while (yerlesen < 40)
            {
                int x = rnd.Next(0, 20);
                int y = rnd.Next(0, 20);

                // Aynı hücreye birden fazla mayın yerleştirilmesi engellenir
                if (!mayinVar[x, y])
                {
                    mayinVar[x, y] = true;
                    yerlesen++;
                }
            }
            // Oyuncunun başlangıç hücresine mayın gelmesi engellenir
            mayinVar[0, 0] = false;
            
            oyuncuX = 0;
            oyuncuY = 0;
            
            hucreler[oyuncuX, oyuncuY].BackColor = Color.Yellow;
            // Oyun aktif hale getirilir
            oyunBasladi = true;
            // Yakındaki mayın sayısı etiketi sıfırlanır
            lblMayinYakin.Text = "Mayınlara Yakın: 0";
            // Zamanlayıcı sıfırlanır
            timer1.Stop();
            saniye = 0;
            timerBasladi = false;
            lblZaman.Text = "Süre: 00:00";

        }

        // Orta seviye seçildiğinde çalışan olay metodu
        // Bu seviyede oyun alanına 50 adet mayın yerleştirilir
        private void rbOrta_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbOrta.Checked) return;

            // Oyun alanı temizlenir
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    mayinVar[i, j] = false;
                    hucreler[i, j].BackColor = Color.LightSkyBlue;
                    hucreler[i, j].Image = null;
                }
            }

            int yerlesen = 0;
            // 50 adet mayın rastgele yerleştirilir
            while (yerlesen < 50)
            {
                int x = rnd.Next(0, 20);
                int y = rnd.Next(0, 20);

                if (!mayinVar[x, y])
                {
                    mayinVar[x, y] = true;
                    yerlesen++;
                }
            }

            mayinVar[0, 0] = false;

            oyuncuX = 0;
            oyuncuY = 0;

            hucreler[oyuncuX, oyuncuY].BackColor = Color.Yellow;
            oyunBasladi = true;

            lblMayinYakin.Text = "Mayınlara Yakın: 0";

            timer1.Stop();
            saniye = 0;
            timerBasladi = false;
            lblZaman.Text = "Süre: 00:00";

        }

        // Zor seviye seçildiğinde çalışan olay metodu
        // Bu seviyede oyun alanına 80 adet mayın yerleştirilir
        private void rbZor_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbZor.Checked) return;

            // Oyun alanı temizlenir
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    mayinVar[i, j] = false;
                    hucreler[i, j].BackColor = Color.LightSkyBlue;
                    hucreler[i, j].Image = null;
                }
            }

            int yerlesen = 0;
            // 80 adet mayın rastgele yerleştirilir
            while (yerlesen < 80)
            {
                int x = rnd.Next(0, 20);
                int y = rnd.Next(0, 20);

                if (!mayinVar[x, y])
                {
                    mayinVar[x, y] = true;
                    yerlesen++;
                }
            }

            mayinVar[0, 0] = false;

            oyuncuX = 0;
            oyuncuY = 0;

            hucreler[oyuncuX, oyuncuY].BackColor = Color.Yellow;
            oyunBasladi = true;

            lblMayinYakin.Text = "Mayınlara Yakın: 0";

            timer1.Stop();
            saniye = 0;
            timerBasladi = false;
            lblZaman.Text = "Süre: 00:00";
        }
        // Oyuncunun sağ yön butonuna bastığında çalışan metot
        private void btnSag_Click(object sender, EventArgs e)
        {
            if (!oyunBasladi) return;
            // Oyuncu ilk kez hareket ettiğinde zamanlayıcı başlatılır
            if (!timerBasladi)
            {
                timer1.Start();
                timerBasladi = true;
            }


            // Sağ sınır kontrolü yapılır
            if (oyuncuY + 1 >= 20)
            {
                MessageBox.Show("Sınır dışına çıkamazsın!");
                return;
            }
            // Oyuncunun önceki bulunduğu hücre gri renge boyanır
            hucreler[oyuncuX, oyuncuY].BackColor = Color.LightGray;
            // Oyuncu sağa hareket ettirilir
            oyuncuY++;
            // Oyuncunun yeni konumu sarı renkle gösterilir
            hucreler[oyuncuX, oyuncuY].BackColor = Color.Yellow;

            // Oyuncu mayınlı bir hücreye bastı mı kontrol edilir
            if (mayinVar[oyuncuX, oyuncuY])
            {   // Tüm mayınlar oyun alanında gösterilir
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (mayinVar[i, j])
                        {
                            hucreler[i, j].Image = Properties.Resources.mayin;
                            hucreler[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
                // Zamanlayıcı durdurulur
                timer1.Stop();
                timerBasladi = false;
                // Oyuncunun kaybetme bilgisi dosyaya kaydedilir
                File.AppendAllText("skorlar.txt",
txtIsim.Text + " - " + lblZaman.Text + " - KAYBETTİ" + Environment.NewLine);

                // Oyuncuya oyun bitti mesajı gösterilir
                DialogResult secim = MessageBox.Show(
             "Mayına bastın! Oyun bitti!\nYeni oyun başlatılsın mı?",
             "Oyun Bitti",
         MessageBoxButtons.YesNo
);
                // Yeni oyun seçimine göre işlem yapılır
                if (secim == DialogResult.Yes)
                {
                    OyunuSifirla();
                }
                else
                {
                    oyunBasladi = false;
                }

                
                return;
            }

            //  MAYINLARA YAKIN HESABI 
            // Oyuncunun bulunduğu konuma komşu hücrelerdeki mayın sayısı hesaplanır
            int sayac = 0;

            if (oyuncuX - 1 >= 0 && mayinVar[oyuncuX - 1, oyuncuY]) sayac++;
            if (oyuncuX + 1 < 20 && mayinVar[oyuncuX + 1, oyuncuY]) sayac++;
            if (oyuncuY - 1 >= 0 && mayinVar[oyuncuX, oyuncuY - 1]) sayac++;
            if (oyuncuY + 1 < 20 && mayinVar[oyuncuX, oyuncuY + 1]) sayac++;
            // Yakındaki mayın sayısı ekranda gösterilir
            lblMayinYakin.Text = "Mayınlara Yakın: " + sayac;


            //  KAZANMA KONTROLÜ
            // Oyuncunun hedef noktaya ulaşıp ulaşmadığı kontrol edilir
            if (oyuncuX == 19 && oyuncuY == 19)
            {
                // Zamanlayıcı durdurulur ve oyun bitirilir
                timer1.Stop();
                timerBasladi = false;
                oyunBasladi = false;
                // Oyuncunun kazanma bilgisi dosyaya kaydedilir
                File.AppendAllText("skorlar.txt",
txtIsim.Text + " - " + lblZaman.Text + " - KAZANDI" + Environment.NewLine);
                // Kazanma mesajı gösterilir
                DialogResult secim = MessageBox.Show(
             "Tebrikler! Oyunu kazandın!\nYeni oyun başlatılsın mı?",
             "Oyun Bitti",
         MessageBoxButtons.YesNo
);
                // Yeni oyun seçimine göre işlem yapılır
                if (secim == DialogResult.Yes)
                {
                    OyunuSifirla();
                }
                else
                {
                    oyunBasladi = false;
                }

                return;
            }
        }
        // Bu metot btnSag_Click ile aynı mantıkta çalışır.
        // Sadece hareket yönü farklıdır.
        private void btnSol_Click(object sender, EventArgs e)
        {
            if (!oyunBasladi) return;

            if (!timerBasladi)
            {
                timer1.Start();
                timerBasladi = true;
            }

           

            if (oyuncuY - 1 < 0)
            {
                MessageBox.Show("Sınır dışına çıkamazsın!");
                return;
            }

            hucreler[oyuncuX, oyuncuY].BackColor = Color.LightGray;
            oyuncuY--;

            hucreler[oyuncuX, oyuncuY].BackColor = Color.Yellow;

            if (mayinVar[oyuncuX, oyuncuY])
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (mayinVar[i, j])
                        {
                            hucreler[i, j].Image = Properties.Resources.mayin;
                            hucreler[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
                timer1.Stop();
                timerBasladi = false;

                File.AppendAllText("skorlar.txt",
txtIsim.Text + " - " + lblZaman.Text + " - KAYBETTİ" + Environment.NewLine);

                DialogResult secim = MessageBox.Show(
             "Mayına bastın! Oyun bitti!\nYeni oyun başlatılsın mı?",
             "Oyun Bitti",
         MessageBoxButtons.YesNo
);

                if (secim == DialogResult.Yes)
                {
                    OyunuSifirla();
                }
                else
                {
                    oyunBasladi = false;
                }
                
                return;


            }

            //  MAYINLARA YAKIN HESABI 
            int sayac = 0;

            if (oyuncuX - 1 >= 0 && mayinVar[oyuncuX - 1, oyuncuY]) sayac++;
            if (oyuncuX + 1 < 20 && mayinVar[oyuncuX + 1, oyuncuY]) sayac++;
            if (oyuncuY - 1 >= 0 && mayinVar[oyuncuX, oyuncuY - 1]) sayac++;
            if (oyuncuY + 1 < 20 && mayinVar[oyuncuX, oyuncuY + 1]) sayac++;

            lblMayinYakin.Text = "Mayınlara Yakın: " + sayac;

            //  KAZANMA KONTROLÜ
            if (oyuncuX == 19 && oyuncuY == 19)
            {
                timer1.Stop();
                timerBasladi = false;
                oyunBasladi = false;

                File.AppendAllText("skorlar.txt",
txtIsim.Text + " - " + lblZaman.Text + " - KAZANDI" + Environment.NewLine);

                DialogResult secim = MessageBox.Show(
             "Tebrikler! Oyunu kazandın!\nYeni oyun başlatılsın mı?",
             "Oyun Bitti",
         MessageBoxButtons.YesNo
);

                if (secim == DialogResult.Yes)
                {
                    OyunuSifirla();
                }
                else
                {
                    oyunBasladi = false;
                }

                return;
            }
        }
        // Bu metot btnSag_Click ile aynı mantıkta çalışır.
        // Sadece hareket yönü farklıdır.
        private void btnYukari_Click(object sender, EventArgs e)
        {
            if (!oyunBasladi) return;

            if (!timerBasladi)
            {
                timer1.Start();
                timerBasladi = true;
            }

            

            if (oyuncuX - 1 < 0)
            {
                MessageBox.Show("Sınır dışına çıkamazsın!");
                return;
            }

            hucreler[oyuncuX, oyuncuY].BackColor = Color.LightGray;
            oyuncuX--;

            hucreler[oyuncuX, oyuncuY].BackColor = Color.Yellow;

            if (mayinVar[oyuncuX, oyuncuY])
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (mayinVar[i, j])
                        {
                            hucreler[i, j].Image = Properties.Resources.mayin;
                            hucreler[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
                timer1.Stop();
                timerBasladi = false;
                
                File.AppendAllText("skorlar.txt",
txtIsim.Text + " - " + lblZaman.Text + " - KAYBETTİ" + Environment.NewLine);

                DialogResult secim = MessageBox.Show(
             "Mayına bastın! Oyun bitti!\nYeni oyun başlatılsın mı?",
             "Oyun Bitti",
         MessageBoxButtons.YesNo
);

                if (secim == DialogResult.Yes)
                {
                    OyunuSifirla();
                }
                else
                {
                    oyunBasladi = false;
                }

                return;
            }

            //  MAYINLARA YAKIN HESABI 
            int sayac = 0;

            if (oyuncuX - 1 >= 0 && mayinVar[oyuncuX - 1, oyuncuY]) sayac++;
            if (oyuncuX + 1 < 20 && mayinVar[oyuncuX + 1, oyuncuY]) sayac++;
            if (oyuncuY - 1 >= 0 && mayinVar[oyuncuX, oyuncuY - 1]) sayac++;
            if (oyuncuY + 1 < 20 && mayinVar[oyuncuX, oyuncuY + 1]) sayac++;

            lblMayinYakin.Text = "Mayınlara Yakın: " + sayac;

            //  KAZANMA KONTROLÜ
            if (oyuncuX == 19 && oyuncuY == 19)
            {
                timer1.Stop();
                timerBasladi = false;
                oyunBasladi = false;

                File.AppendAllText("skorlar.txt",
txtIsim.Text + " - " + lblZaman.Text + " - KAZANDI" + Environment.NewLine);

                DialogResult secim = MessageBox.Show(
             "Tebrikler! Oyunu kazandın!\nYeni oyun başlatılsın mı?",
             "Oyun Bitti",
         MessageBoxButtons.YesNo
);

                if (secim == DialogResult.Yes)
                {
                    OyunuSifirla();
                }
                else
                {
                    oyunBasladi = false;
                }

                return;
            }
        }
        // Bu metot btnSag_Click ile aynı mantıkta çalışır.
        // Sadece hareket yönü farklıdır.
        private void btnAsagi_Click(object sender, EventArgs e)
        {
            if (!oyunBasladi) return;

            if (!timerBasladi)
            {
                timer1.Start();
                timerBasladi = true;
            }

            

            if (oyuncuX + 1 >= 20)
            {
                MessageBox.Show("Sınır dışına çıkamazsın!");
                return;
            }

            hucreler[oyuncuX, oyuncuY].BackColor = Color.LightGray;
            oyuncuX++;

            hucreler[oyuncuX, oyuncuY].BackColor = Color.Yellow;

            if (mayinVar[oyuncuX, oyuncuY])
            {
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        if (mayinVar[i, j])
                        {
                            hucreler[i, j].Image = Properties.Resources.mayin;
                            hucreler[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
                timer1.Stop();
                timerBasladi = false;
              
                File.AppendAllText("skorlar.txt",
txtIsim.Text + " - " + lblZaman.Text + " - KAYBETTİ" + Environment.NewLine);

                DialogResult secim = MessageBox.Show(
             "Mayına bastın! Oyun bitti!\nYeni oyun başlatılsın mı?",
             "Oyun Bitti",
         MessageBoxButtons.YesNo
);

                if (secim == DialogResult.Yes)
                {
                    OyunuSifirla();
                }
                else
                {
                    oyunBasladi = false;
                }

                
                return;
            }

            //  MAYINLARA YAKIN HESABI 
            int sayac = 0;

            if (oyuncuX - 1 >= 0 && mayinVar[oyuncuX - 1, oyuncuY]) sayac++;
            if (oyuncuX + 1 < 20 && mayinVar[oyuncuX + 1, oyuncuY]) sayac++;
            if (oyuncuY - 1 >= 0 && mayinVar[oyuncuX, oyuncuY - 1]) sayac++;
            if (oyuncuY + 1 < 20 && mayinVar[oyuncuX, oyuncuY + 1]) sayac++;

            lblMayinYakin.Text = "Mayınlara Yakın: " + sayac;

            //  KAZANMA KONTROLÜ
            if (oyuncuX == 19 && oyuncuY == 19)
            {
                timer1.Stop();
                timerBasladi = false;
                oyunBasladi = false;

                File.AppendAllText("skorlar.txt",
txtIsim.Text + " - " + lblZaman.Text + " - KAZANDI" + Environment.NewLine);

               
                DialogResult secim = MessageBox.Show(
             "Tebrikler! Oyunu kazandın!\nYeni oyun başlatılsın mı?",
             "Oyun Bitti",
         MessageBoxButtons.YesNo
);

                if (secim == DialogResult.Yes)
                {
                    OyunuSifirla();
                }
                else
                {
                    oyunBasladi = false;
                }
                return;
            }
        }
        // Timer her tetiklendiğinde çalışan metot
        // Oyun süresini saniye cinsinden artırır ve ekranda gösterir
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;// Geçen süre 1 saniye artırılır
            // Saniye bilgisi dakika ve saniye olarak hesaplanır
            int dk = saniye / 60;
            int sn = saniye % 60;
            // Süre etiketi dakika:saniye formatında güncellenir
            lblZaman.Text = "Süre: " + dk.ToString("00") + ":" + sn.ToString("00");
        }

        // Oyuncu adını kaydetme butonuna basıldığında çalışan metot
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Girilen oyuncu adı ekranda mesaj olarak gösterilir
            MessageBox.Show(txtIsim.Text + " kaydedildi.");
        }
        
        // Oyunun yazarı ve nasıl oynanacağı hakkında bilgi verir
        private void btnYardim_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Mayın Tarlası Oyunu\n\n" +
        "Yazar: Büşra Amine Yanal\n\n" +
        "Nasıl Oynanır:\n" +
        "- Oyuncu adı girilir.\n" +
        "- Zorluk seviyesi seçilir.\n" +
        "- Yön butonları ile hareket edilir.\n" +
        "- Mayınlara basmadan hedefe ulaşılmaya çalışılır.\n" +
        "- Süre otomatik olarak tutulur.",
        "Yardım"
    );
        }
        // Skorları görüntüle butonuna basıldığında çalışan metot
        // Oyun sonuçlarını dosyadan okuyarak kullanıcıya gösterir
        private void btnSkorlar_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists("skorlar.txt"))
            {// Skor dosyası yoksa kullanıcı bilgilendirilir
                MessageBox.Show("Henüz kayıtlı skor yok.");
                return;
            }
            // Skorlar dosyadan okunur
            string skorlar = File.ReadAllText("skorlar.txt");
            // Okunan skorlar mesaj kutusunda gösterilir
            MessageBox.Show(skorlar, "Skorlar");
        }

 
        private void btnalt_Click(object sender, EventArgs e)
        {//Burda formun minimize butonunu ekledim.Daha güzel görünmesi için.
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnkap_Click(object sender, EventArgs e)
        {//Burda formun close butonunu ekledim.Daha güzel görünmesi için.
            Application.Exit();
        }
    }
}
