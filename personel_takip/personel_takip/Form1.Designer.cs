
namespace personel_takip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_personel = new System.Windows.Forms.TextBox();
            this.lbl_personel = new System.Windows.Forms.Label();
            this.btn_son_prs_ad = new System.Windows.Forms.Button();
            this.btn_maas_3_elmn_arttır = new System.Windows.Forms.Button();
            this.btn_tplm_maas = new System.Windows.Forms.Button();
            this.btn_mas_4_7_arası = new System.Windows.Forms.Button();
            this.btn_maas_4000_az_olan = new System.Windows.Forms.Button();
            this.btn_yks_maas = new System.Windows.Forms.Button();
            this.btn_dsk_maas = new System.Windows.Forms.Button();
            this.btn_tpl_prsl = new System.Windows.Forms.Button();
            this.btn_lis_temizle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_olustur_listele = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.lbl_sonuc);
            this.groupBox1.Controls.Add(this.btn_ara);
            this.groupBox1.Controls.Add(this.txt_personel);
            this.groupBox1.Controls.Add(this.lbl_personel);
            this.groupBox1.Controls.Add(this.btn_son_prs_ad);
            this.groupBox1.Controls.Add(this.btn_maas_3_elmn_arttır);
            this.groupBox1.Controls.Add(this.btn_tplm_maas);
            this.groupBox1.Controls.Add(this.btn_mas_4_7_arası);
            this.groupBox1.Controls.Add(this.btn_maas_4000_az_olan);
            this.groupBox1.Controls.Add(this.btn_yks_maas);
            this.groupBox1.Controls.Add(this.btn_dsk_maas);
            this.groupBox1.Controls.Add(this.btn_tpl_prsl);
            this.groupBox1.Controls.Add(this.btn_lis_temizle);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btn_olustur_listele);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(53, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Kaydı";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(417, 342);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(63, 25);
            this.lbl_sonuc.TabIndex = 14;
            this.lbl_sonuc.Text = "Sonuç:";
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(216, 226);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(64, 32);
            this.btn_ara.TabIndex = 13;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_personel
            // 
            this.txt_personel.Location = new System.Drawing.Point(92, 229);
            this.txt_personel.Name = "txt_personel";
            this.txt_personel.Size = new System.Drawing.Size(100, 33);
            this.txt_personel.TabIndex = 12;
            // 
            // lbl_personel
            // 
            this.lbl_personel.AutoSize = true;
            this.lbl_personel.Location = new System.Drawing.Point(15, 232);
            this.lbl_personel.Name = "lbl_personel";
            this.lbl_personel.Size = new System.Drawing.Size(79, 25);
            this.lbl_personel.TabIndex = 11;
            this.lbl_personel.Text = "Personel";
            // 
            // btn_son_prs_ad
            // 
            this.btn_son_prs_ad.Location = new System.Drawing.Point(558, 212);
            this.btn_son_prs_ad.Name = "btn_son_prs_ad";
            this.btn_son_prs_ad.Size = new System.Drawing.Size(136, 98);
            this.btn_son_prs_ad.TabIndex = 10;
            this.btn_son_prs_ad.Text = "Son Personelin Adı";
            this.btn_son_prs_ad.UseVisualStyleBackColor = true;
            this.btn_son_prs_ad.Click += new System.EventHandler(this.btn_son_prs_ad_Click);
            // 
            // btn_maas_3_elmn_arttır
            // 
            this.btn_maas_3_elmn_arttır.Location = new System.Drawing.Point(437, 212);
            this.btn_maas_3_elmn_arttır.Name = "btn_maas_3_elmn_arttır";
            this.btn_maas_3_elmn_arttır.Size = new System.Drawing.Size(124, 111);
            this.btn_maas_3_elmn_arttır.TabIndex = 9;
            this.btn_maas_3_elmn_arttır.Text = "Listedeki 3.Elemanın Maaşını 5000 Arttır";
            this.btn_maas_3_elmn_arttır.UseVisualStyleBackColor = true;
            this.btn_maas_3_elmn_arttır.Click += new System.EventHandler(this.btn_maas_3_elmn_arttır_Click);
            // 
            // btn_tplm_maas
            // 
            this.btn_tplm_maas.Location = new System.Drawing.Point(316, 212);
            this.btn_tplm_maas.Name = "btn_tplm_maas";
            this.btn_tplm_maas.Size = new System.Drawing.Size(124, 98);
            this.btn_tplm_maas.TabIndex = 8;
            this.btn_tplm_maas.Text = "Toplam Ödenen Maaş";
            this.btn_tplm_maas.UseVisualStyleBackColor = true;
            this.btn_tplm_maas.Click += new System.EventHandler(this.btn_tplm_maas_Click);
            // 
            // btn_mas_4_7_arası
            // 
            this.btn_mas_4_7_arası.Location = new System.Drawing.Point(558, 120);
            this.btn_mas_4_7_arası.Name = "btn_mas_4_7_arası";
            this.btn_mas_4_7_arası.Size = new System.Drawing.Size(124, 98);
            this.btn_mas_4_7_arası.TabIndex = 7;
            this.btn_mas_4_7_arası.Text = "Maaşı 5000-7000 Arası Olanların Sayısı";
            this.btn_mas_4_7_arası.UseVisualStyleBackColor = true;
            this.btn_mas_4_7_arası.Click += new System.EventHandler(this.btn_mas_4_7_arası_Click);
            // 
            // btn_maas_4000_az_olan
            // 
            this.btn_maas_4000_az_olan.Location = new System.Drawing.Point(437, 120);
            this.btn_maas_4000_az_olan.Name = "btn_maas_4000_az_olan";
            this.btn_maas_4000_az_olan.Size = new System.Drawing.Size(124, 98);
            this.btn_maas_4000_az_olan.TabIndex = 6;
            this.btn_maas_4000_az_olan.Text = "Maaşı 4000 Den Az Olanlar";
            this.btn_maas_4000_az_olan.UseVisualStyleBackColor = true;
            this.btn_maas_4000_az_olan.Click += new System.EventHandler(this.btn_maas_4000_az_olan_Click);
            // 
            // btn_yks_maas
            // 
            this.btn_yks_maas.Location = new System.Drawing.Point(316, 120);
            this.btn_yks_maas.Name = "btn_yks_maas";
            this.btn_yks_maas.Size = new System.Drawing.Size(124, 98);
            this.btn_yks_maas.TabIndex = 5;
            this.btn_yks_maas.Text = "En Yüksek Maaşlı Personel";
            this.btn_yks_maas.UseVisualStyleBackColor = true;
            this.btn_yks_maas.Click += new System.EventHandler(this.btn_yks_maas_Click);
            // 
            // btn_dsk_maas
            // 
            this.btn_dsk_maas.Location = new System.Drawing.Point(558, 31);
            this.btn_dsk_maas.Name = "btn_dsk_maas";
            this.btn_dsk_maas.Size = new System.Drawing.Size(124, 98);
            this.btn_dsk_maas.TabIndex = 4;
            this.btn_dsk_maas.Text = "En Düşük Maaş";
            this.btn_dsk_maas.UseVisualStyleBackColor = true;
            this.btn_dsk_maas.Click += new System.EventHandler(this.btn_dsk_maas_Click);
            // 
            // btn_tpl_prsl
            // 
            this.btn_tpl_prsl.Location = new System.Drawing.Point(437, 31);
            this.btn_tpl_prsl.Name = "btn_tpl_prsl";
            this.btn_tpl_prsl.Size = new System.Drawing.Size(124, 98);
            this.btn_tpl_prsl.TabIndex = 3;
            this.btn_tpl_prsl.Text = "Toplam Personeli Göster";
            this.btn_tpl_prsl.UseVisualStyleBackColor = true;
            this.btn_tpl_prsl.Click += new System.EventHandler(this.btn_tpl_prsl_Click);
            // 
            // btn_lis_temizle
            // 
            this.btn_lis_temizle.Location = new System.Drawing.Point(316, 31);
            this.btn_lis_temizle.Name = "btn_lis_temizle";
            this.btn_lis_temizle.Size = new System.Drawing.Size(124, 98);
            this.btn_lis_temizle.TabIndex = 2;
            this.btn_lis_temizle.Text = "Lis box Temizle";
            this.btn_lis_temizle.UseVisualStyleBackColor = true;
            this.btn_lis_temizle.Click += new System.EventHandler(this.btn_lis_temizle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(22, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 79);
            this.listBox1.TabIndex = 1;
            // 
            // btn_olustur_listele
            // 
            this.btn_olustur_listele.Location = new System.Drawing.Point(29, 31);
            this.btn_olustur_listele.Name = "btn_olustur_listele";
            this.btn_olustur_listele.Size = new System.Drawing.Size(163, 32);
            this.btn_olustur_listele.TabIndex = 0;
            this.btn_olustur_listele.Text = "Oluştur ve Listele";
            this.btn_olustur_listele.UseVisualStyleBackColor = true;
            this.btn_olustur_listele.Click += new System.EventHandler(this.btn_olustur_listele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(834, 463);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_personel;
        private System.Windows.Forms.Label lbl_personel;
        private System.Windows.Forms.Button btn_son_prs_ad;
        private System.Windows.Forms.Button btn_maas_3_elmn_arttır;
        private System.Windows.Forms.Button btn_tplm_maas;
        private System.Windows.Forms.Button btn_mas_4_7_arası;
        private System.Windows.Forms.Button btn_maas_4000_az_olan;
        private System.Windows.Forms.Button btn_yks_maas;
        private System.Windows.Forms.Button btn_dsk_maas;
        private System.Windows.Forms.Button btn_tpl_prsl;
        private System.Windows.Forms.Button btn_lis_temizle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_olustur_listele;
    }
}

