using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veter
{
    public partial class HastaKayit : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=HP-LAPTOP\\SQLEXPRESS;Initial Catalog=vet_KullaniciKayit;Integrated Security=True");


        

        public HastaKayit()
        {
            InitializeComponent();
        }
       void veriler()
       {
          
            baglanti.Open();
            SqlDataAdapter da =new SqlDataAdapter("SELECT * FROM HastaKayit",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
       }

        bool durum;


        void tekrar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from HastaKayit where CİpNo=@c", baglanti);
            komut.Parameters.AddWithValue("@c", txtCipNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }

            baglanti.Close();
        }




        private void btn_Hasta_Kayit_Click(object sender, EventArgs e)
        {
            string sahipAd = txtSahipAd.Text;
            string sahipSoyad=txtSahipSoyad.Text;
            string kimlik=txtKimlikNo.Text;
            string tel = txtTelNo.Text;
            string adres = txtAdres.Text;
            string hastaAdi = txtHastaAdi.Text;
            string hastaTürü = comboHastaTürü.Text;
            string cins = comboCins.Text;
            string ırk = txtIrk.Text;
            string cipNo=txtCipNo.Text;
            
               if(string.IsNullOrEmpty(sahipAd) || string.IsNullOrEmpty(sahipSoyad) || string.IsNullOrEmpty(kimlik) || string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(adres) || string.IsNullOrEmpty(hastaAdi) || string.IsNullOrEmpty(hastaTürü) || string.IsNullOrEmpty(cins) || string.IsNullOrEmpty(ırk) || string.IsNullOrEmpty(cipNo))
            {
                MessageBox.Show("Bilgileri eksiksiz doldurunuz");
            }
               else
               {
                tekrar();

                if (durum == true)
                {
                    string sorgu = "insert into HastaKayit(SahipAd,SahipSoyad,KimlikNo,TelNo,Adres,HastaAdi,HastaTürü,Cins,Irk,CipNo) values(@sahipad,@sahipsoyad,@kimlikno,@telno,@adres,@hastaadı,@hastatürü,@cins,@ırk,@cipno)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@sahipad", txtSahipAd.Text);
                    komut.Parameters.AddWithValue("@sahipsoyad", txtSahipSoyad.Text);
                    komut.Parameters.AddWithValue("@kimlikno", txtKimlikNo.Text);
                    komut.Parameters.AddWithValue("@telno", txtTelNo.Text);
                    komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                    komut.Parameters.AddWithValue("@hastaadı", txtHastaAdi.Text);
                    komut.Parameters.AddWithValue("@hastatürü", comboHastaTürü.Text);
                    komut.Parameters.AddWithValue("@cins", comboHastaTürü.Text);
                    komut.Parameters.AddWithValue("@ırk", txtIrk.Text);
                    komut.Parameters.AddWithValue("@cipno", txtCipNo.Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    veriler();
                    MessageBox.Show("Hasta Eklendi");
                }
                else
                {
                    MessageBox.Show("Kişi daha önceden kayıt edilmiş.");
                }

            }
           
        }

  
        private void HastaKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vet_KullaniciKayitDataSet11.HastaKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaKayitTableAdapter.Fill(this.vet_KullaniciKayitDataSet11.HastaKayit);

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSahipAd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSahipSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKimlikNo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtHastaAdi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           comboHastaTürü.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
              comboCins.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtIrk.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtCipNo.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();



        }


       

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from HastaKayit where SahipAd=@sahipad";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@sahipad",txtSahipAd.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE HastaKayit SET SahipAd=@sahipad,SahipSoyad=@sahipsoyad,KimlikNo=@kimlikno,TelNo=@telno,Adres=@adres,HastaAdi=@hastaadi,HastaTürü=@hastatürü,Cins=@cins,Irk=@ırk,CipNo=@cipno";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@sahipad", txtSahipAd.Text);
            komut.Parameters.AddWithValue("@sahipsoyad", txtSahipSoyad.Text);
            komut.Parameters.AddWithValue("@kimlikno", txtKimlikNo.Text);
            komut.Parameters.AddWithValue("@telno", txtTelNo.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@hastaadi", txtHastaAdi.Text);
            komut.Parameters.AddWithValue("@hastatürü", comboHastaTürü.Text);
            komut.Parameters.AddWithValue("@cins", comboHastaTürü.Text);
            komut.Parameters.AddWithValue("@ırk", txtIrk.Text);
            komut.Parameters.AddWithValue("@cipno", txtCipNo.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();

        }
    }
}
