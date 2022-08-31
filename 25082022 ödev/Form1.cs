using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25082022_ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BankaOdevDBEntities db;
        Banka banka;
        Musteri musteri;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new BankaOdevDBEntities();

        }




        private void btnBankaEkle_Click(object sender, EventArgs e)
        {
            banka = new Banka()
            {
                BankaAdı = txtBankaAd.Text,
                BankaSahibi = txtBankaSahibi.Text
            };
            db.Bankas.Add(banka);
            db.SaveChanges();
            MessageBox.Show("Banka Eklendi..");
        }

        private void btnBankaSil_Click(object sender, EventArgs e)
        {
            int silinecekBankaID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value); 
            var silinecekBanka = db.Bankas.Where(x => x.BankaID == silinecekBankaID).FirstOrDefault();         

            db.Bankas.Remove(silinecekBanka);
            db.SaveChanges();
            dataGridView1.DataSource = db.Bankas.ToList();
        }

        private void btnBankaGrntl_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Bankas
                .Select(x => new
                {
                    x.BankaID,
                    x.BankaAdı,
                    x.BankaSahibi
                }).ToList();
                
            MessageBox.Show("Sistemde Kayıtlı Bankalar Gösteriliyor.");
        }

        private void btnBankaGuncelle_Click(object sender, EventArgs e)
        {

            var guncelle = db.Bankas.Where(x => x.BankaID == Convert.ToInt32(txtBankaID.Text)).FirstOrDefault();
            guncelle.BankaAdı = txtBankaAd.Text;           

            db.SaveChanges();
            dataGridView1.DataSource = db.Bankas.ToList();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            musteri = new Musteri()
            {
                Ad=txtMusteriAd.Text,
                Soyad=txtMusteriSoyad.Text,
                TcNo=txtMusteriTc.Text,
                HesapNumarası=txtMusteriHesapNo.Text,
                BankaID=Convert.ToInt32(txtBankaID2.Text)
            };
            db.Musteris.Add(musteri);
            db.SaveChanges();
            MessageBox.Show("Müşteri Eklendi..");
        }

        private void btnMusterileriGoruntule_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = db.Musteris
                .Select(x => new
                {
                    x.MusteriID,
                    x.Ad,
                    x.Soyad,                  
                    x.TcNo,
                    x.HesapNumarası
                }).ToList();             
                
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            int silinecekID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            var silinecekMusteri = db.Musteris.Where(x => x.MusteriID == silinecekID).FirstOrDefault();

            db.Musteris.Remove(silinecekMusteri);
            db.SaveChanges();
            dataGridView2.DataSource = db.Musteris.ToList();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            var guncelle = db.Musteris.Where(x => x.MusteriID == Convert.ToInt32(txtMusteriID.Text)).FirstOrDefault();
            guncelle.Ad = txtMusteriAd.Text;
            guncelle.Soyad = txtMusteriSoyad.Text;
            guncelle.TcNo = txtMusteriTc.Text;
            guncelle.HesapNumarası = txtMusteriHesapNo.Text;
            

            db.SaveChanges();
        }
    }
}
