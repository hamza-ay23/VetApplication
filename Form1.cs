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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti= new SqlConnection("Data Source=HP-LAPTOP\\SQLEXPRESS;Initial Catalog=vet_KullaniciKayit;Integrated Security=True");
        bool durum;
        void tekrar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kullanicii where kullanici=@k", baglanti);
            komut.Parameters.AddWithValue("@k", txt_Kullanici_Adi.Text);
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
        private void button1_Click(object sender, EventArgs e)
        {
           

            string kullaniciadi = txt_Kullanici_Adi.Text;
            string şifre = txt_Sifre.Text;

            //textboxlardan gelen veriyi değişkenlere eşitledik
            //burda isnullorempty değşkenlerden boş değer gelirse onları bulacak ve bool bir değer döndürecek

            if (string.IsNullOrEmpty(kullaniciadi) || string.IsNullOrEmpty(şifre))
            {
                MessageBox.Show("lütfen bir değer giriniz");
            }
            else
            {
                tekrar();

                if (durum == true)
                {
                    string query = "insert into Kullanicii(kullanici,sifre) values(@Kullanici1,@şifre1)";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@Kullanici1", txt_Kullanici_Adi.Text);
                    komut.Parameters.AddWithValue("şifre1", txt_Sifre.Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("başarılı bir şekilde kayıt oldunuz");
                    txt_Kullanici_Adi.Clear();
                    txt_Sifre.Clear();
                    baglanti.Close();

                }
                else
                {
                    MessageBox.Show("böyle bir kullanıcı mevcuttur");
                }

            

            }
        
                
        
        }
     
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from kullanicii where kullanici ='"+txt_Kullanici_Adi.Text+"'and sifre='"+txt_Sifre.Text+"'", baglanti);
            SqlDataReader dataReader = komut1.ExecuteReader();
            if (dataReader.Read())
            {
                
                this.Hide();
              HastaKayit secenek = new HastaKayit();
                secenek.ShowDialog();

            }
            else
            {
                
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                txt_Kullanici_Adi.Clear();
                txt_Sifre.Clear();
            }
          baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vet_KullaniciKayitDataSet.kullanicii' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullaniciiTableAdapter.Fill(this.vet_KullaniciKayitDataSet.kullanicii);

        }
    }
}
