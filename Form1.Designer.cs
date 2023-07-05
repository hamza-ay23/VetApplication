namespace veter
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_Kullanici_Adi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.kullaniciiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vet_KullaniciKayitDataSet = new veter.vet_KullaniciKayitDataSet();
            this.kullaniciiTableAdapter = new veter.vet_KullaniciKayitDataSetTableAdapters.kullaniciiTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vet_KullaniciKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı;";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(60, 91);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(28, 13);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre";
            // 
            // txt_Kullanici_Adi
            // 
            this.txt_Kullanici_Adi.Location = new System.Drawing.Point(137, 50);
            this.txt_Kullanici_Adi.Name = "txt_Kullanici_Adi";
            this.txt_Kullanici_Adi.Size = new System.Drawing.Size(100, 20);
            this.txt_Kullanici_Adi.TabIndex = 2;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(137, 84);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_Sifre.TabIndex = 3;
            // 
            // btn_kayit
            // 
            this.btn_kayit.BackColor = System.Drawing.Color.Green;
            this.btn_kayit.Location = new System.Drawing.Point(137, 154);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(75, 33);
            this.btn_kayit.TabIndex = 4;
            this.btn_kayit.Text = "Kayıt Ol";
            this.btn_kayit.UseVisualStyleBackColor = false;
            this.btn_kayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Giris.Location = new System.Drawing.Point(137, 193);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(75, 29);
            this.btn_Giris.TabIndex = 5;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // kullaniciiBindingSource
            // 
            this.kullaniciiBindingSource.DataMember = "kullanicii";
            this.kullaniciiBindingSource.DataSource = this.vet_KullaniciKayitDataSet;
            // 
            // vet_KullaniciKayitDataSet
            // 
            this.vet_KullaniciKayitDataSet.DataSetName = "vet_KullaniciKayitDataSet";
            this.vet_KullaniciKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciiTableAdapter
            // 
            this.kullaniciiTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(258, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Veteriner Kayıt Ekranı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(470, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_Kullanici_Adi);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vet_KullaniciKayitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_Kullanici_Adi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Button btn_Giris;
        private vet_KullaniciKayitDataSet vet_KullaniciKayitDataSet;
        private System.Windows.Forms.BindingSource kullaniciiBindingSource;
        private vet_KullaniciKayitDataSetTableAdapters.kullaniciiTableAdapter kullaniciiTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}

