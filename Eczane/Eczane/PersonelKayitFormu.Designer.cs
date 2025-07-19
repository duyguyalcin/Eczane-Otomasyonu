namespace Eczane
{
    partial class PersonelKayitFormu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPersonelKayit = new System.Windows.Forms.GroupBox();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.dtpPerKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtPerSifre = new System.Windows.Forms.TextBox();
            this.txtPerEposta = new System.Windows.Forms.TextBox();
            this.txtPerKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtPerAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonellerView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.btnPersonelKayitGeri = new System.Windows.Forms.Button();
            this.grpPersonelKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerView)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonelKayit
            // 
            this.grpPersonelKayit.BackColor = System.Drawing.Color.SlateGray;
            this.grpPersonelKayit.Controls.Add(this.btnPersonelKaydet);
            this.grpPersonelKayit.Controls.Add(this.dtpPerKayitTarihi);
            this.grpPersonelKayit.Controls.Add(this.txtPerSifre);
            this.grpPersonelKayit.Controls.Add(this.txtPerEposta);
            this.grpPersonelKayit.Controls.Add(this.txtPerKullaniciAdi);
            this.grpPersonelKayit.Controls.Add(this.txtPerAdi);
            this.grpPersonelKayit.Controls.Add(this.label6);
            this.grpPersonelKayit.Controls.Add(this.label5);
            this.grpPersonelKayit.Controls.Add(this.label4);
            this.grpPersonelKayit.Controls.Add(this.label3);
            this.grpPersonelKayit.Controls.Add(this.label2);
            this.grpPersonelKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpPersonelKayit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpPersonelKayit.Location = new System.Drawing.Point(199, 172);
            this.grpPersonelKayit.Name = "grpPersonelKayit";
            this.grpPersonelKayit.Size = new System.Drawing.Size(503, 502);
            this.grpPersonelKayit.TabIndex = 1;
            this.grpPersonelKayit.TabStop = false;
            this.grpPersonelKayit.Text = "PERSONEL KAYIT";
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.BackColor = System.Drawing.Color.Silver;
            this.btnPersonelKaydet.Location = new System.Drawing.Point(176, 404);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(148, 41);
            this.btnPersonelKaydet.TabIndex = 10;
            this.btnPersonelKaydet.Text = "Kaydet";
            this.btnPersonelKaydet.UseVisualStyleBackColor = false;
            this.btnPersonelKaydet.Click += new System.EventHandler(this.btnPersonelKaydet_Click);
            // 
            // dtpPerKayitTarihi
            // 
            this.dtpPerKayitTarihi.Location = new System.Drawing.Point(184, 315);
            this.dtpPerKayitTarihi.Name = "dtpPerKayitTarihi";
            this.dtpPerKayitTarihi.Size = new System.Drawing.Size(275, 27);
            this.dtpPerKayitTarihi.TabIndex = 9;
            // 
            // txtPerSifre
            // 
            this.txtPerSifre.Location = new System.Drawing.Point(184, 253);
            this.txtPerSifre.Name = "txtPerSifre";
            this.txtPerSifre.Size = new System.Drawing.Size(275, 27);
            this.txtPerSifre.TabIndex = 8;
            // 
            // txtPerEposta
            // 
            this.txtPerEposta.Location = new System.Drawing.Point(185, 197);
            this.txtPerEposta.Name = "txtPerEposta";
            this.txtPerEposta.Size = new System.Drawing.Size(274, 27);
            this.txtPerEposta.TabIndex = 7;
            // 
            // txtPerKullaniciAdi
            // 
            this.txtPerKullaniciAdi.Location = new System.Drawing.Point(185, 139);
            this.txtPerKullaniciAdi.Name = "txtPerKullaniciAdi";
            this.txtPerKullaniciAdi.Size = new System.Drawing.Size(274, 27);
            this.txtPerKullaniciAdi.TabIndex = 6;
            // 
            // txtPerAdi
            // 
            this.txtPerAdi.Location = new System.Drawing.Point(185, 84);
            this.txtPerAdi.Name = "txtPerAdi";
            this.txtPerAdi.Size = new System.Drawing.Size(274, 27);
            this.txtPerAdi.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(28, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Kayıt Tarihi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(28, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Şifre:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-posta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı Adı:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı Soyadı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PersonellerView
            // 
            this.PersonellerView.BackgroundColor = System.Drawing.Color.LightGray;
            this.PersonellerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonellerView.Location = new System.Drawing.Point(805, 225);
            this.PersonellerView.Name = "PersonellerView";
            this.PersonellerView.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.PersonellerView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PersonellerView.RowTemplate.Height = 24;
            this.PersonellerView.Size = new System.Drawing.Size(903, 449);
            this.PersonellerView.TabIndex = 2;
            this.PersonellerView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonellerView_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(805, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "PERSONEL LİSTESİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.BackColor = System.Drawing.Color.SlateGray;
            this.btnPersonelSil.Location = new System.Drawing.Point(1593, 680);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(115, 33);
            this.btnPersonelSil.TabIndex = 4;
            this.btnPersonelSil.Text = "Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = false;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.BackColor = System.Drawing.Color.SlateGray;
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(805, 680);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(408, 33);
            this.btnPersonelGuncelle.TabIndex = 5;
            this.btnPersonelGuncelle.Text = "Güncelle";
            this.btnPersonelGuncelle.UseVisualStyleBackColor = false;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // btnPersonelKayitGeri
            // 
            this.btnPersonelKayitGeri.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPersonelKayitGeri.Location = new System.Drawing.Point(13, 13);
            this.btnPersonelKayitGeri.Name = "btnPersonelKayitGeri";
            this.btnPersonelKayitGeri.Size = new System.Drawing.Size(138, 58);
            this.btnPersonelKayitGeri.TabIndex = 6;
            this.btnPersonelKayitGeri.Text = "Geri";
            this.btnPersonelKayitGeri.UseVisualStyleBackColor = false;
            this.btnPersonelKayitGeri.Click += new System.EventHandler(this.btnPersonelKayitGeri_Click);
            // 
            // PersonelKayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 728);
            this.Controls.Add(this.btnPersonelKayitGeri);
            this.Controls.Add(this.btnPersonelGuncelle);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersonellerView);
            this.Controls.Add(this.grpPersonelKayit);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "PersonelKayitFormu";
            this.Text = "PERSONEL KAYIT PANELİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PersonelKayitFormu_Load);
            this.grpPersonelKayit.ResumeLayout(false);
            this.grpPersonelKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonelKayit;
        private System.Windows.Forms.DataGridView PersonellerView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnPersonelGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPersonelKaydet;
        private System.Windows.Forms.DateTimePicker dtpPerKayitTarihi;
        private System.Windows.Forms.TextBox txtPerSifre;
        private System.Windows.Forms.TextBox txtPerEposta;
        private System.Windows.Forms.TextBox txtPerKullaniciAdi;
        private System.Windows.Forms.TextBox txtPerAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPersonelKayitGeri;
    }
}