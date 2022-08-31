namespace _25082022_ödev
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBankaEkle = new System.Windows.Forms.Button();
            this.txtBankaAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBankaSahibi = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriHesapNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMusteriTc = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnBankaGrntl = new System.Windows.Forms.Button();
            this.btnBankaSil = new System.Windows.Forms.Button();
            this.btnBankaGuncelle = new System.Windows.Forms.Button();
            this.btnMusterileriGoruntule = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBankaID = new System.Windows.Forms.TextBox();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBankaID2 = new System.Windows.Forms.TextBox();
            this.BankaID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBankaID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBankaSahibi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBankaAd);
            this.groupBox1.Controls.Add(this.btnBankaEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banka Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBankaID2);
            this.groupBox2.Controls.Add(this.BankaID);
            this.groupBox2.Controls.Add(this.txtMusteriID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMusteriHesapNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMusteriTc);
            this.groupBox2.Controls.Add(this.txtMusteriSoyad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnMusteriEkle);
            this.groupBox2.Controls.Add(this.txtMusteriAd);
            this.groupBox2.Location = new System.Drawing.Point(601, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka Adı :";
            // 
            // btnBankaEkle
            // 
            this.btnBankaEkle.Location = new System.Drawing.Point(98, 145);
            this.btnBankaEkle.Name = "btnBankaEkle";
            this.btnBankaEkle.Size = new System.Drawing.Size(331, 66);
            this.btnBankaEkle.TabIndex = 1;
            this.btnBankaEkle.Text = "Banka Ekle";
            this.btnBankaEkle.UseVisualStyleBackColor = true;
            this.btnBankaEkle.Click += new System.EventHandler(this.btnBankaEkle_Click);
            // 
            // txtBankaAd
            // 
            this.txtBankaAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankaAd.Location = new System.Drawing.Point(130, 32);
            this.txtBankaAd.Name = "txtBankaAd";
            this.txtBankaAd.Size = new System.Drawing.Size(271, 20);
            this.txtBankaAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Banka Sahibi  :";
            // 
            // txtBankaSahibi
            // 
            this.txtBankaSahibi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankaSahibi.Location = new System.Drawing.Point(130, 72);
            this.txtBankaSahibi.Name = "txtBankaSahibi";
            this.txtBankaSahibi.Size = new System.Drawing.Size(271, 20);
            this.txtBankaSahibi.TabIndex = 4;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMusteriSoyad.Location = new System.Drawing.Point(134, 68);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(271, 20);
            this.txtMusteriSoyad.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad :";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMusteriAd.Location = new System.Drawing.Point(134, 28);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(271, 20);
            this.txtMusteriAd.TabIndex = 7;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(102, 235);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(331, 36);
            this.btnMusteriEkle.TabIndex = 6;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ad :";
            // 
            // txtMusteriHesapNo
            // 
            this.txtMusteriHesapNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMusteriHesapNo.Location = new System.Drawing.Point(134, 135);
            this.txtMusteriHesapNo.Name = "txtMusteriHesapNo";
            this.txtMusteriHesapNo.Size = new System.Drawing.Size(271, 20);
            this.txtMusteriHesapNo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(30, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tc No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hesap No : ";
            // 
            // txtMusteriTc
            // 
            this.txtMusteriTc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMusteriTc.Location = new System.Drawing.Point(134, 103);
            this.txtMusteriTc.Name = "txtMusteriTc";
            this.txtMusteriTc.Size = new System.Drawing.Size(271, 20);
            this.txtMusteriTc.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 373);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(600, 357);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(550, 373);
            this.dataGridView2.TabIndex = 3;
            // 
            // btnBankaGrntl
            // 
            this.btnBankaGrntl.Location = new System.Drawing.Point(12, 296);
            this.btnBankaGrntl.Name = "btnBankaGrntl";
            this.btnBankaGrntl.Size = new System.Drawing.Size(122, 42);
            this.btnBankaGrntl.TabIndex = 5;
            this.btnBankaGrntl.Text = "Bankaları Görüntüle";
            this.btnBankaGrntl.UseVisualStyleBackColor = true;
            this.btnBankaGrntl.Click += new System.EventHandler(this.btnBankaGrntl_Click);
            // 
            // btnBankaSil
            // 
            this.btnBankaSil.Location = new System.Drawing.Point(225, 296);
            this.btnBankaSil.Name = "btnBankaSil";
            this.btnBankaSil.Size = new System.Drawing.Size(122, 42);
            this.btnBankaSil.TabIndex = 6;
            this.btnBankaSil.Text = "Banka Sil";
            this.btnBankaSil.UseVisualStyleBackColor = true;
            this.btnBankaSil.Click += new System.EventHandler(this.btnBankaSil_Click);
            // 
            // btnBankaGuncelle
            // 
            this.btnBankaGuncelle.Location = new System.Drawing.Point(440, 296);
            this.btnBankaGuncelle.Name = "btnBankaGuncelle";
            this.btnBankaGuncelle.Size = new System.Drawing.Size(122, 42);
            this.btnBankaGuncelle.TabIndex = 7;
            this.btnBankaGuncelle.Text = "Bankaları Güncelle";
            this.btnBankaGuncelle.UseVisualStyleBackColor = true;
            this.btnBankaGuncelle.Click += new System.EventHandler(this.btnBankaGuncelle_Click);
            // 
            // btnMusterileriGoruntule
            // 
            this.btnMusterileriGoruntule.Location = new System.Drawing.Point(600, 296);
            this.btnMusterileriGoruntule.Name = "btnMusterileriGoruntule";
            this.btnMusterileriGoruntule.Size = new System.Drawing.Size(122, 42);
            this.btnMusterileriGoruntule.TabIndex = 8;
            this.btnMusterileriGoruntule.Text = "Müşterileri Görüntüle";
            this.btnMusterileriGoruntule.UseVisualStyleBackColor = true;
            this.btnMusterileriGoruntule.Click += new System.EventHandler(this.btnMusterileriGoruntule_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(819, 296);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(122, 42);
            this.btnMusteriSil.TabIndex = 9;
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(1028, 296);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(122, 42);
            this.btnMusteriGuncelle.TabIndex = 10;
            this.btnMusteriGuncelle.Text = "Müşteri Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(26, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Banka ID :";
            // 
            // txtBankaID
            // 
            this.txtBankaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankaID.Location = new System.Drawing.Point(130, 111);
            this.txtBankaID.Name = "txtBankaID";
            this.txtBankaID.Size = new System.Drawing.Size(271, 20);
            this.txtBankaID.TabIndex = 7;
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMusteriID.Location = new System.Drawing.Point(134, 204);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(271, 20);
            this.txtMusteriID.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Müşteri ID  : ";
            // 
            // txtBankaID2
            // 
            this.txtBankaID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBankaID2.Location = new System.Drawing.Point(134, 168);
            this.txtBankaID2.Name = "txtBankaID2";
            this.txtBankaID2.Size = new System.Drawing.Size(271, 20);
            this.txtBankaID2.TabIndex = 17;
            // 
            // BankaID
            // 
            this.BankaID.AutoSize = true;
            this.BankaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BankaID.Location = new System.Drawing.Point(30, 169);
            this.BankaID.Name = "BankaID";
            this.BankaID.Size = new System.Drawing.Size(74, 16);
            this.BankaID.TabIndex = 16;
            this.BankaID.Text = "Banka ID  : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnMusterileriGoruntule);
            this.Controls.Add(this.btnBankaGuncelle);
            this.Controls.Add(this.btnBankaSil);
            this.Controls.Add(this.btnBankaGrntl);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBankaSahibi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBankaAd;
        private System.Windows.Forms.Button btnBankaEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMusteriHesapNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMusteriTc;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnBankaGrntl;
        private System.Windows.Forms.Button btnBankaSil;
        private System.Windows.Forms.Button btnBankaGuncelle;
        private System.Windows.Forms.Button btnMusterileriGoruntule;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.TextBox txtBankaID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBankaID2;
        private System.Windows.Forms.Label BankaID;
    }
}

