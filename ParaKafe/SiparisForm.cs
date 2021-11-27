using ParaKae.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParaKafe
{
    public partial class SiparisForm : Form
    {
        private readonly Siparis siparis;
        private readonly KafeVeri db;

        EventHandler<MasaTasindiEventArgs> MasaTasindi;

        private readonly BindingList<SiparisDetay> blDetaylar;

        public SiparisForm(Siparis siparis, KafeVeri db)
        {
            this.siparis = siparis; //local değişkenle class ın ismi aynı diye kafamız karışmasın diye this ile belirttik
            this.db = db;
            blDetaylar = new BindingList<SiparisDetay>(siparis.SiparisDetaylar);
            blDetaylar.ListChanged += BlDetaylar_ListChanged;
            InitializeComponent();
            dgvsiparisDetaylar.AutoGenerateColumns = false;
            dgvsiparisDetaylar.DataSource = blDetaylar;
            UrunleriListele();
            MasaNoyuGuncelle();
            OdemeTutariniGuncelle();
        }

        private void BlDetaylar_ListChanged(object sender, ListChangedEventArgs e)
        {
            OdemeTutariniGuncelle();
        }

        private void OdemeTutariniGuncelle()
        {
            lblOdemeTutari.Text = siparis.ToplamTutarTL;
        }

        private void MasaNoyuGuncelle()
        {
            Text = $"Masa {siparis.MasaNo}";
            lblMasaNo.Text = siparis.MasaNo.ToString("00");

            // Adım 37
            // Masa taşıyabilmek için boş masaNo ları cboMasano ya ekledik
            // Bos masaNoları alabilmek için aktif siparislerdeki masaNo ları bir diziye atıp sonrasında, Enumerable Range ile 1'den toplam masa adeti kadar numara içinden bu dizide olmayanları yani bos olanları çektik
            int[] doluMasalar = db.AktifSiparisler.Select(x => x.MasaNo).ToArray();
            cboMasaNo.DataSource = Enumerable
                .Range(1, db.MasaAdet)
                .Where(x => !doluMasalar.Contains(x))
                .ToList();
        }

        private void UrunleriListele()
        {
            cboUrun.DataSource = db.Urunler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var sd = new SiparisDetay();
            Urun urun = (Urun)cboUrun.SelectedItem;
            sd.UrunAd = urun.UrunAd;
            sd.BirimFiyat = urun.BirimFiyat;
            sd.Adet = (int)nudAdet.Value;
            blDetaylar.Add(sd);

        }

        private void btnAnasayfayaDon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            SiparisiKapat(SiparisDurum.Iptal, 0);
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            SiparisiKapat(SiparisDurum.Odendi, siparis.ToplamTutar());
        }

        private void SiparisiKapat(SiparisDurum durum, decimal odenenTutar)
        {
            siparis.KapanisZamani = DateTime.Now;
            siparis.Durum = durum;
            siparis.OdenenTutar = odenenTutar;
            db.AktifSiparisler.Remove(siparis);
            db.GecmisSiparisler.Add(siparis);
            Close();
        }

        private void btnMasaTasi_Click(object sender, EventArgs e)
        {
            // Adım 38
            if (cboMasaNo.SelectedIndex == -1) return;

            // Adım 39
            int eskiMasaNo = siparis.MasaNo;
            int hedefMasaNo = (int)cboMasaNo.SelectedItem;
            siparis.MasaNo = hedefMasaNo;
            MasaNoyuGuncelle();

            // Adım 42
            if (MasaTasindi != null)
                MasaTasindi(this, new MasaTasindiEventArgs(eskiMasaNo, hedefMasaNo));
        }
    }
}
