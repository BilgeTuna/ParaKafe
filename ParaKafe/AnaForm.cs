using Newtonsoft.Json;
using ParaKae.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaKafe
{
    public partial class AnaForm : Form
    {
        KafeVeri db = new KafeVeri();
        public AnaForm()
        {
            OrnekUrunleriYukle();
            InitializeComponent();
            MasalariOlustur();
        }

        private void OrnekUrunleriYukle()
        {
            db.Urunler.Add(new Urun() { UrunAd = "Ayran", BirimFiyat = 4.50m });
            db.Urunler.Add(new Urun() { UrunAd = "Kola", BirimFiyat = 5.50m });
        }

        private void MasalariOlustur()
        {
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                ListViewItem lvi = new ListViewItem($"Masa{i}");
                lvi.Tag = i;
                lvi.ImageKey = "bos";
                lvwMasalar.Items.Add(lvi);
            }
        }

        private void lvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = lvwMasalar.SelectedItems[0];
            int no = (int)lvi.Tag; //masaya tıkladığımızda masa1 değil sadece 1 yaszın istiyoruz 
            // (int) yazdık çünkü unboxing ile objeden int e çevirmemiz lazımdı

            Siparis siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == no);

            if (siparis == null)
            {
                siparis = new Siparis() { MasaNo = no };
                db.AktifSiparisler.Add(siparis);
                lvi.ImageKey = "dolu";
            }

            SiparisForm sf = new SiparisForm(siparis, db);
            sf.ShowDialog();

            if (siparis.Durum != SiparisDurum.Aktif)
            {
                lvi.ImageKey = "bos";
            }
        }

        private void Sf_MasaTasindi(object sender, MasaTasindiEventArgs e)
        {
            foreach (ListViewItem lvi in lvwMasalar.Items)
            {
                if ((int)lvi.Tag == e.EskiMasaNo) lvi.ImageKey = "bos";
                if ((int)lvi.Tag == e.YeniMasaNo) lvi.ImageKey = "dolu";
            }
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            new GecmisSiparislerForm(db).ShowDialog();
        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            new UrunlerForm(db).ShowDialog();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Adım 32
            // Form kapanırken verileri Json ile kaydedebilmek için bu eventi oluşturduk
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            // Adım 33
            // Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution yolundan json ı ParaKafe projemize ekledik
            // tüm listeleri tutan KafeVeri classından oluşturduğumuz db yi json ile bir dosyaya yazdırdık
            string json = JsonConvert.SerializeObject(db);
            File.WriteAllText("veri.json", json);

        }

        private void VerileriOku()
        {
            // Adım 34
            // Dosya hiç oluşturulmamışsa veya bozulmuşsa diye hata almamak için try catch yaptık
            try
            {
                // Adım 34.1
                // Dosya varsa ve okunabiliyorsa KafeVeri türünde açarak db ye atadık
                string json = File.ReadAllText("veri.json");
                db = JsonConvert.DeserializeObject<KafeVeri>(json);
            }
            catch (Exception)
            {
                // Adım 34.2
                // Dosya bozuksa veya hiç oluşturulmamışsa 0'dan yeni db oluşturarak içinde birkaç örnek ürün oluşturduğumuz metodu çağırdık
                db = new KafeVeri();
                OrnekUrunleriYukle();
            }
        }
    }
}
