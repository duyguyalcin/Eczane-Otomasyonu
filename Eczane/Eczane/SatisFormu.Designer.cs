namespace Eczane
{
    partial class SatisFormu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSatısGeri = new System.Windows.Forms.Button();
            this.grpSatıs = new System.Windows.Forms.GroupBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.cmbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpEklenenIlaclar = new System.Windows.Forms.GroupBox();
            this.EklenenIlaclarView = new System.Windows.Forms.DataGridView();
            this.btnSatıs = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtRecete = new System.Windows.Forms.TextBox();
            this.txtHastaTc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SonucView = new System.Windows.Forms.DataGridView();
            this.txtilacAra = new System.Windows.Forms.TextBox();
            this.grpSatıs.SuspendLayout();
            this.grpEklenenIlaclar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EklenenIlaclarView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SonucView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSatısGeri
            // 
            this.btnSatısGeri.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSatısGeri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSatısGeri.Location = new System.Drawing.Point(12, 12);
            this.btnSatısGeri.Name = "btnSatısGeri";
            this.btnSatısGeri.Size = new System.Drawing.Size(138, 58);
            this.btnSatısGeri.TabIndex = 0;
            this.btnSatısGeri.Text = "Geri";
            this.btnSatısGeri.UseVisualStyleBackColor = false;
            this.btnSatısGeri.Click += new System.EventHandler(this.btnSatısGeri_Click);
            // 
            // grpSatıs
            // 
            this.grpSatıs.BackColor = System.Drawing.Color.SlateGray;
            this.grpSatıs.Controls.Add(this.txtFiyat);
            this.grpSatıs.Controls.Add(this.cmbOdemeTipi);
            this.grpSatıs.Controls.Add(this.label6);
            this.grpSatıs.Controls.Add(this.grpEklenenIlaclar);
            this.grpSatıs.Controls.Add(this.btnSatıs);
            this.grpSatıs.Controls.Add(this.dtpTarih);
            this.grpSatıs.Controls.Add(this.txtRecete);
            this.grpSatıs.Controls.Add(this.txtHastaTc);
            this.grpSatıs.Controls.Add(this.label4);
            this.grpSatıs.Controls.Add(this.label3);
            this.grpSatıs.Controls.Add(this.label2);
            this.grpSatıs.Controls.Add(this.label1);
            this.grpSatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSatıs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpSatıs.Location = new System.Drawing.Point(51, 125);
            this.grpSatıs.Name = "grpSatıs";
            this.grpSatıs.Size = new System.Drawing.Size(615, 796);
            this.grpSatıs.TabIndex = 1;
            this.grpSatıs.TabStop = false;
            this.grpSatıs.Text = "Ödeme";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(205, 567);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(344, 27);
            this.txtFiyat.TabIndex = 15;
            // 
            // cmbOdemeTipi
            // 
            this.cmbOdemeTipi.FormattingEnabled = true;
            this.cmbOdemeTipi.Location = new System.Drawing.Point(198, 638);
            this.cmbOdemeTipi.Name = "cmbOdemeTipi";
            this.cmbOdemeTipi.Size = new System.Drawing.Size(345, 28);
            this.cmbOdemeTipi.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(36, 637);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ödeme Tipi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpEklenenIlaclar
            // 
            this.grpEklenenIlaclar.Controls.Add(this.EklenenIlaclarView);
            this.grpEklenenIlaclar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpEklenenIlaclar.Location = new System.Drawing.Point(40, 249);
            this.grpEklenenIlaclar.Name = "grpEklenenIlaclar";
            this.grpEklenenIlaclar.Size = new System.Drawing.Size(509, 292);
            this.grpEklenenIlaclar.TabIndex = 12;
            this.grpEklenenIlaclar.TabStop = false;
            this.grpEklenenIlaclar.Text = "Eklenen İlaçlar";
            // 
            // EklenenIlaclarView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EklenenIlaclarView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EklenenIlaclarView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EklenenIlaclarView.Location = new System.Drawing.Point(6, 26);
            this.EklenenIlaclarView.Name = "EklenenIlaclarView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EklenenIlaclarView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EklenenIlaclarView.RowHeadersWidth = 51;
            this.EklenenIlaclarView.RowTemplate.Height = 24;
            this.EklenenIlaclarView.Size = new System.Drawing.Size(497, 251);
            this.EklenenIlaclarView.TabIndex = 15;
            this.EklenenIlaclarView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EklenenIlaclarView_CellContentClick);
            this.EklenenIlaclarView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EklenenIlaclarView_CellDoubleClick);
            // 
            // btnSatıs
            // 
            this.btnSatıs.ForeColor = System.Drawing.Color.SlateGray;
            this.btnSatıs.Location = new System.Drawing.Point(228, 719);
            this.btnSatıs.Name = "btnSatıs";
            this.btnSatıs.Size = new System.Drawing.Size(118, 49);
            this.btnSatıs.TabIndex = 11;
            this.btnSatıs.Text = "Sat";
            this.btnSatıs.UseVisualStyleBackColor = true;
            this.btnSatıs.Click += new System.EventHandler(this.btnSatıs_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(199, 120);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(344, 27);
            this.dtpTarih.TabIndex = 8;
            // 
            // txtRecete
            // 
            this.txtRecete.Location = new System.Drawing.Point(199, 172);
            this.txtRecete.Name = "txtRecete";
            this.txtRecete.Size = new System.Drawing.Size(344, 27);
            this.txtRecete.TabIndex = 6;
            // 
            // txtHastaTc
            // 
            this.txtHastaTc.Location = new System.Drawing.Point(199, 77);
            this.txtHastaTc.Name = "txtHastaTc";
            this.txtHastaTc.Size = new System.Drawing.Size(344, 27);
            this.txtHastaTc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(36, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Reçete:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fiyat:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(36, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Tc:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SlateGray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(680, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1239, 47);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reçete Görüntüleme";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SonucView
            // 
            this.SonucView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SonucView.Location = new System.Drawing.Point(684, 274);
            this.SonucView.Name = "SonucView";
            this.SonucView.RowHeadersWidth = 51;
            this.SonucView.RowTemplate.Height = 24;
            this.SonucView.Size = new System.Drawing.Size(1235, 392);
            this.SonucView.TabIndex = 13;
            this.SonucView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SonucView_CellContentClick);
            this.SonucView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SonucView_CellDoubleClick);
            // 
            // txtilacAra
            // 
            this.txtilacAra.Location = new System.Drawing.Point(684, 202);
            this.txtilacAra.Multiline = true;
            this.txtilacAra.Name = "txtilacAra";
            this.txtilacAra.Size = new System.Drawing.Size(1235, 41);
            this.txtilacAra.TabIndex = 14;
            this.txtilacAra.TextChanged += new System.EventHandler(this.txtilacAra_TextChanged);
            // 
            // SatisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.txtilacAra);
            this.Controls.Add(this.SonucView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpSatıs);
            this.Controls.Add(this.btnSatısGeri);
            this.Name = "SatisFormu";
            this.Text = "İlaç Şatiş  Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SatisFormu_Load);
            this.grpSatıs.ResumeLayout(false);
            this.grpSatıs.PerformLayout();
            this.grpEklenenIlaclar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EklenenIlaclarView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SonucView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSatısGeri;
        private System.Windows.Forms.GroupBox grpSatıs;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtRecete;
        private System.Windows.Forms.TextBox txtHastaTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSatıs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView SonucView;
        private System.Windows.Forms.GroupBox grpEklenenIlaclar;
        private System.Windows.Forms.DataGridView EklenenIlaclarView;
        private System.Windows.Forms.ComboBox cmbOdemeTipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtilacAra;
        private System.Windows.Forms.TextBox txtFiyat;
    }
}