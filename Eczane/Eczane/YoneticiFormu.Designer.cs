namespace Eczane
{
    partial class YoneticiFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiFormu));
            this.btnPersonelKayit = new System.Windows.Forms.Button();
            this.btnIlacEkle = new System.Windows.Forms.Button();
            this.btnOdemePlani = new System.Windows.Forms.Button();
            this.btnCıkış = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPersonelKayit
            // 
            this.btnPersonelKayit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnPersonelKayit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPersonelKayit.Location = new System.Drawing.Point(107, 438);
            this.btnPersonelKayit.Name = "btnPersonelKayit";
            this.btnPersonelKayit.Size = new System.Drawing.Size(270, 76);
            this.btnPersonelKayit.TabIndex = 0;
            this.btnPersonelKayit.Text = "Personel Kayıt";
            this.btnPersonelKayit.UseVisualStyleBackColor = false;
            this.btnPersonelKayit.Click += new System.EventHandler(this.btnPersonelKayit_Click);
            // 
            // btnIlacEkle
            // 
            this.btnIlacEkle.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnIlacEkle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIlacEkle.Location = new System.Drawing.Point(597, 440);
            this.btnIlacEkle.Name = "btnIlacEkle";
            this.btnIlacEkle.Size = new System.Drawing.Size(266, 72);
            this.btnIlacEkle.TabIndex = 1;
            this.btnIlacEkle.Text = "İlaç Ekle";
            this.btnIlacEkle.UseVisualStyleBackColor = false;
            this.btnIlacEkle.Click += new System.EventHandler(this.btnIlacEkle_Click);
            // 
            // btnOdemePlani
            // 
            this.btnOdemePlani.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnOdemePlani.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOdemePlani.Location = new System.Drawing.Point(1061, 438);
            this.btnOdemePlani.Name = "btnOdemePlani";
            this.btnOdemePlani.Size = new System.Drawing.Size(270, 72);
            this.btnOdemePlani.TabIndex = 2;
            this.btnOdemePlani.Text = "Ödeme Planı";
            this.btnOdemePlani.UseVisualStyleBackColor = false;
            this.btnOdemePlani.Click += new System.EventHandler(this.btnOdemePlani_Click);
            // 
            // btnCıkış
            // 
            this.btnCıkış.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCıkış.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCıkış.Location = new System.Drawing.Point(12, 12);
            this.btnCıkış.Name = "btnCıkış";
            this.btnCıkış.Size = new System.Drawing.Size(138, 58);
            this.btnCıkış.TabIndex = 4;
            this.btnCıkış.Text = "Çıkış";
            this.btnCıkış.UseVisualStyleBackColor = false;
            this.btnCıkış.Click += new System.EventHandler(this.btnCıkış_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(597, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 301);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1061, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(270, 301);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.btnPersonelKayit);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btnIlacEkle);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnOdemePlani);
            this.groupBox1.Location = new System.Drawing.Point(279, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1440, 592);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // YoneticiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCıkış);
            this.Name = "YoneticiFormu";
            this.Text = "YÖNETİCİ PANELİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelKayit;
        private System.Windows.Forms.Button btnIlacEkle;
        private System.Windows.Forms.Button btnOdemePlani;
        private System.Windows.Forms.Button btnCıkış;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}