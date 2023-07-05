namespace veter
{
    partial class HastaKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vet_KullaniciKayitDataSet1 = new veter.vet_KullaniciKayitDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboHastaTürü = new System.Windows.Forms.ComboBox();
            this.comboCins = new System.Windows.Forms.ComboBox();
            this.txtSahipAd = new System.Windows.Forms.TextBox();
            this.txtSahipSoyad = new System.Windows.Forms.TextBox();
            this.txtKimlikNo = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.txtIrk = new System.Windows.Forms.TextBox();
            this.txtCipNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sahipAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahipSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimlikNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ırkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cİpNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vet_KullaniciKayitDataSet11 = new veter.vet_KullaniciKayitDataSet1();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnHastaKayit = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.hastaKayitTableAdapter = new veter.vet_KullaniciKayitDataSet1TableAdapters.HastaKayitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vet_KullaniciKayitDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vet_KullaniciKayitDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // vet_KullaniciKayitDataSet1
            // 
            this.vet_KullaniciKayitDataSet1.DataSetName = "vet_KullaniciKayitDataSet";
            this.vet_KullaniciKayitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Kayıt Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sahip Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sahip Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kimlik No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tel No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hasta Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Irk";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Çip No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hasta Türü";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cins";
            // 
            // comboHastaTürü
            // 
            this.comboHastaTürü.FormattingEnabled = true;
            this.comboHastaTürü.Items.AddRange(new object[] {
            "Kedi",
            "Köpek"});
            this.comboHastaTürü.Location = new System.Drawing.Point(345, 71);
            this.comboHastaTürü.Name = "comboHastaTürü";
            this.comboHastaTürü.Size = new System.Drawing.Size(121, 21);
            this.comboHastaTürü.TabIndex = 11;
            // 
            // comboCins
            // 
            this.comboCins.FormattingEnabled = true;
            this.comboCins.Items.AddRange(new object[] {
            "Erkek\t",
            "Dişi"});
            this.comboCins.Location = new System.Drawing.Point(345, 98);
            this.comboCins.Name = "comboCins";
            this.comboCins.Size = new System.Drawing.Size(121, 21);
            this.comboCins.TabIndex = 12;
            // 
            // txtSahipAd
            // 
            this.txtSahipAd.Location = new System.Drawing.Point(93, 46);
            this.txtSahipAd.Name = "txtSahipAd";
            this.txtSahipAd.Size = new System.Drawing.Size(100, 20);
            this.txtSahipAd.TabIndex = 13;
            // 
            // txtSahipSoyad
            // 
            this.txtSahipSoyad.Location = new System.Drawing.Point(93, 72);
            this.txtSahipSoyad.Name = "txtSahipSoyad";
            this.txtSahipSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSahipSoyad.TabIndex = 14;
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.Location = new System.Drawing.Point(93, 99);
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(100, 20);
            this.txtKimlikNo.TabIndex = 15;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(93, 125);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(100, 20);
            this.txtTelNo.TabIndex = 16;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(93, 151);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 17;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(345, 49);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtHastaAdi.TabIndex = 18;
            // 
            // txtIrk
            // 
            this.txtIrk.Location = new System.Drawing.Point(345, 125);
            this.txtIrk.Name = "txtIrk";
            this.txtIrk.Size = new System.Drawing.Size(100, 20);
            this.txtIrk.TabIndex = 19;
            // 
            // txtCipNo
            // 
            this.txtCipNo.Location = new System.Drawing.Point(345, 151);
            this.txtCipNo.Name = "txtCipNo";
            this.txtCipNo.Size = new System.Drawing.Size(100, 20);
            this.txtCipNo.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sahipAdDataGridViewTextBoxColumn,
            this.sahipSoyadDataGridViewTextBoxColumn,
            this.kimlikNoDataGridViewTextBoxColumn,
            this.telNoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.hastaAdiDataGridViewTextBoxColumn,
            this.hastaTürüDataGridViewTextBoxColumn,
            this.cinsDataGridViewTextBoxColumn,
            this.ırkDataGridViewTextBoxColumn,
            this.cİpNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaKayitBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 206);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(813, 170);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // sahipAdDataGridViewTextBoxColumn
            // 
            this.sahipAdDataGridViewTextBoxColumn.DataPropertyName = "SahipAd";
            this.sahipAdDataGridViewTextBoxColumn.HeaderText = "SahipAd";
            this.sahipAdDataGridViewTextBoxColumn.Name = "sahipAdDataGridViewTextBoxColumn";
            // 
            // sahipSoyadDataGridViewTextBoxColumn
            // 
            this.sahipSoyadDataGridViewTextBoxColumn.DataPropertyName = "SahipSoyad";
            this.sahipSoyadDataGridViewTextBoxColumn.HeaderText = "SahipSoyad";
            this.sahipSoyadDataGridViewTextBoxColumn.Name = "sahipSoyadDataGridViewTextBoxColumn";
            // 
            // kimlikNoDataGridViewTextBoxColumn
            // 
            this.kimlikNoDataGridViewTextBoxColumn.DataPropertyName = "KimlikNo";
            this.kimlikNoDataGridViewTextBoxColumn.HeaderText = "KimlikNo";
            this.kimlikNoDataGridViewTextBoxColumn.Name = "kimlikNoDataGridViewTextBoxColumn";
            // 
            // telNoDataGridViewTextBoxColumn
            // 
            this.telNoDataGridViewTextBoxColumn.DataPropertyName = "TelNo";
            this.telNoDataGridViewTextBoxColumn.HeaderText = "TelNo";
            this.telNoDataGridViewTextBoxColumn.Name = "telNoDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // hastaAdiDataGridViewTextBoxColumn
            // 
            this.hastaAdiDataGridViewTextBoxColumn.DataPropertyName = "HastaAdi";
            this.hastaAdiDataGridViewTextBoxColumn.HeaderText = "HastaAdi";
            this.hastaAdiDataGridViewTextBoxColumn.Name = "hastaAdiDataGridViewTextBoxColumn";
            // 
            // hastaTürüDataGridViewTextBoxColumn
            // 
            this.hastaTürüDataGridViewTextBoxColumn.DataPropertyName = "HastaTürü";
            this.hastaTürüDataGridViewTextBoxColumn.HeaderText = "HastaTürü";
            this.hastaTürüDataGridViewTextBoxColumn.Name = "hastaTürüDataGridViewTextBoxColumn";
            // 
            // cinsDataGridViewTextBoxColumn
            // 
            this.cinsDataGridViewTextBoxColumn.DataPropertyName = "Cins";
            this.cinsDataGridViewTextBoxColumn.HeaderText = "Cins";
            this.cinsDataGridViewTextBoxColumn.Name = "cinsDataGridViewTextBoxColumn";
            // 
            // ırkDataGridViewTextBoxColumn
            // 
            this.ırkDataGridViewTextBoxColumn.DataPropertyName = "Irk";
            this.ırkDataGridViewTextBoxColumn.HeaderText = "Irk";
            this.ırkDataGridViewTextBoxColumn.Name = "ırkDataGridViewTextBoxColumn";
            // 
            // cİpNoDataGridViewTextBoxColumn
            // 
            this.cİpNoDataGridViewTextBoxColumn.DataPropertyName = "CİpNo";
            this.cİpNoDataGridViewTextBoxColumn.HeaderText = "CİpNo";
            this.cİpNoDataGridViewTextBoxColumn.Name = "cİpNoDataGridViewTextBoxColumn";
            // 
            // hastaKayitBindingSource
            // 
            this.hastaKayitBindingSource.DataMember = "HastaKayit";
            this.hastaKayitBindingSource.DataSource = this.vet_KullaniciKayitDataSet11;
            // 
            // vet_KullaniciKayitDataSet11
            // 
            this.vet_KullaniciKayitDataSet11.DataSetName = "vet_KullaniciKayitDataSet1";
            this.vet_KullaniciKayitDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(633, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // btnHastaKayit
            // 
            this.btnHastaKayit.Location = new System.Drawing.Point(370, 177);
            this.btnHastaKayit.Name = "btnHastaKayit";
            this.btnHastaKayit.Size = new System.Drawing.Size(75, 23);
            this.btnHastaKayit.TabIndex = 23;
            this.btnHastaKayit.Text = "Kayıt Et";
            this.btnHastaKayit.UseVisualStyleBackColor = true;
            this.btnHastaKayit.Click += new System.EventHandler(this.btn_Hasta_Kayit_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(472, 382);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(554, 382);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // hastaKayitTableAdapter
            // 
            this.hastaKayitTableAdapter.ClearBeforeFill = true;
            // 
            // HastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(845, 417);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnHastaKayit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCipNo);
            this.Controls.Add(this.txtIrk);
            this.Controls.Add(this.txtHastaAdi);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtKimlikNo);
            this.Controls.Add(this.txtSahipSoyad);
            this.Controls.Add(this.txtSahipAd);
            this.Controls.Add(this.comboCins);
            this.Controls.Add(this.comboHastaTürü);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HastaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaKayit";
            this.Load += new System.EventHandler(this.HastaKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vet_KullaniciKayitDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vet_KullaniciKayitDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private vet_KullaniciKayitDataSet vet_KullaniciKayitDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboHastaTürü;
        private System.Windows.Forms.ComboBox comboCins;
        private System.Windows.Forms.TextBox txtSahipAd;
        private System.Windows.Forms.TextBox txtSahipSoyad;
        private System.Windows.Forms.TextBox txtKimlikNo;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.TextBox txtIrk;
        private System.Windows.Forms.TextBox txtCipNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnHastaKayit;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private vet_KullaniciKayitDataSet1 vet_KullaniciKayitDataSet11;
        private System.Windows.Forms.BindingSource hastaKayitBindingSource;
        private vet_KullaniciKayitDataSet1TableAdapters.HastaKayitTableAdapter hastaKayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahipAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahipSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlikNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ırkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cİpNoDataGridViewTextBoxColumn;
    }
}