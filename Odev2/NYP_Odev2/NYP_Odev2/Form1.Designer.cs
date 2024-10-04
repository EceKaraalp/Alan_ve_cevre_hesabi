
namespace NYP_Odev2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAnaEkran = new System.Windows.Forms.TabPage();
            this.temizleButton = new System.Windows.Forms.Button();
            this.textBoxRenk = new System.Windows.Forms.TextBox();
            this.labelRenk = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonDaire = new System.Windows.Forms.RadioButton();
            this.radioButtonUcgen = new System.Windows.Forms.RadioButton();
            this.radioButtonDikdortgen = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonİleri = new System.Windows.Forms.Button();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.tabPageAnaliz = new System.Windows.Forms.TabPage();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageAnaEkran.SuspendLayout();
            this.tabPageAnaliz.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAnaEkran);
            this.tabControl1.Controls.Add(this.tabPageAnaliz);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageAnaEkran
            // 
            this.tabPageAnaEkran.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPageAnaEkran.Controls.Add(this.temizleButton);
            this.tabPageAnaEkran.Controls.Add(this.textBoxRenk);
            this.tabPageAnaEkran.Controls.Add(this.labelRenk);
            this.tabPageAnaEkran.Controls.Add(this.textBox2);
            this.tabPageAnaEkran.Controls.Add(this.textBox1);
            this.tabPageAnaEkran.Controls.Add(this.radioButtonDaire);
            this.tabPageAnaEkran.Controls.Add(this.radioButtonUcgen);
            this.tabPageAnaEkran.Controls.Add(this.radioButtonDikdortgen);
            this.tabPageAnaEkran.Controls.Add(this.label3);
            this.tabPageAnaEkran.Controls.Add(this.label2);
            this.tabPageAnaEkran.Controls.Add(this.label1);
            this.tabPageAnaEkran.Controls.Add(this.buttonİleri);
            this.tabPageAnaEkran.Controls.Add(this.buttonHesapla);
            this.tabPageAnaEkran.Location = new System.Drawing.Point(4, 25);
            this.tabPageAnaEkran.Name = "tabPageAnaEkran";
            this.tabPageAnaEkran.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnaEkran.Size = new System.Drawing.Size(792, 419);
            this.tabPageAnaEkran.TabIndex = 0;
            this.tabPageAnaEkran.Text = "Ana Ekran";
            // 
            // temizleButton
            // 
            this.temizleButton.Location = new System.Drawing.Point(538, 315);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(104, 51);
            this.temizleButton.TabIndex = 12;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.UseVisualStyleBackColor = true;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // textBoxRenk
            // 
            this.textBoxRenk.Location = new System.Drawing.Point(285, 233);
            this.textBoxRenk.Name = "textBoxRenk";
            this.textBoxRenk.Size = new System.Drawing.Size(100, 22);
            this.textBoxRenk.TabIndex = 11;
            // 
            // labelRenk
            // 
            this.labelRenk.AutoSize = true;
            this.labelRenk.Location = new System.Drawing.Point(104, 233);
            this.labelRenk.Name = "labelRenk";
            this.labelRenk.Size = new System.Drawing.Size(49, 17);
            this.labelRenk.TabIndex = 10;
            this.labelRenk.Text = "Renk :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // radioButtonDaire
            // 
            this.radioButtonDaire.AutoSize = true;
            this.radioButtonDaire.Location = new System.Drawing.Point(399, 81);
            this.radioButtonDaire.Name = "radioButtonDaire";
            this.radioButtonDaire.Size = new System.Drawing.Size(63, 21);
            this.radioButtonDaire.TabIndex = 7;
            this.radioButtonDaire.TabStop = true;
            this.radioButtonDaire.Text = "Daire";
            this.radioButtonDaire.UseVisualStyleBackColor = true;
            // 
            // radioButtonUcgen
            // 
            this.radioButtonUcgen.AutoSize = true;
            this.radioButtonUcgen.Location = new System.Drawing.Point(245, 81);
            this.radioButtonUcgen.Name = "radioButtonUcgen";
            this.radioButtonUcgen.Size = new System.Drawing.Size(126, 21);
            this.radioButtonUcgen.TabIndex = 6;
            this.radioButtonUcgen.TabStop = true;
            this.radioButtonUcgen.Text = "Eşkenar Üçgen";
            this.radioButtonUcgen.UseVisualStyleBackColor = true;
            // 
            // radioButtonDikdortgen
            // 
            this.radioButtonDikdortgen.AutoSize = true;
            this.radioButtonDikdortgen.Location = new System.Drawing.Point(104, 81);
            this.radioButtonDikdortgen.Name = "radioButtonDikdortgen";
            this.radioButtonDikdortgen.Size = new System.Drawing.Size(98, 21);
            this.radioButtonDikdortgen.TabIndex = 5;
            this.radioButtonDikdortgen.TabStop = true;
            this.radioButtonDikdortgen.Text = "Dikdörtgen";
            this.radioButtonDikdortgen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kısa Kenar / Açı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uzun Kenar / Kenar / Çap :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şekil Giriniz :";
            // 
            // buttonİleri
            // 
            this.buttonİleri.Location = new System.Drawing.Point(368, 315);
            this.buttonİleri.Name = "buttonİleri";
            this.buttonİleri.Size = new System.Drawing.Size(104, 51);
            this.buttonİleri.TabIndex = 1;
            this.buttonİleri.Text = "İleri";
            this.buttonİleri.UseVisualStyleBackColor = true;
            this.buttonİleri.Click += new System.EventHandler(this.buttonİleri_Click);
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(195, 315);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(104, 51);
            this.buttonHesapla.TabIndex = 0;
            this.buttonHesapla.Text = "Hesapla";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // tabPageAnaliz
            // 
            this.tabPageAnaliz.BackColor = System.Drawing.Color.Thistle;
            this.tabPageAnaliz.Controls.Add(this.buttonGeri);
            this.tabPageAnaliz.Controls.Add(this.buttonTemizle);
            this.tabPageAnaliz.Controls.Add(this.listView1);
            this.tabPageAnaliz.Location = new System.Drawing.Point(4, 25);
            this.tabPageAnaliz.Name = "tabPageAnaliz";
            this.tabPageAnaliz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnaliz.Size = new System.Drawing.Size(792, 419);
            this.tabPageAnaliz.TabIndex = 1;
            this.tabPageAnaliz.Text = "Analiz Sonuçları";
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(413, 338);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(102, 44);
            this.buttonGeri.TabIndex = 2;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(248, 338);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(102, 44);
            this.buttonTemizle.TabIndex = 1;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(725, 281);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageAnaEkran.ResumeLayout(false);
            this.tabPageAnaEkran.PerformLayout();
            this.tabPageAnaliz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAnaEkran;
        private System.Windows.Forms.TabPage tabPageAnaliz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonİleri;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonDaire;
        private System.Windows.Forms.RadioButton radioButtonUcgen;
        private System.Windows.Forms.RadioButton radioButtonDikdortgen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBoxRenk;
        private System.Windows.Forms.Label labelRenk;
        private System.Windows.Forms.Button temizleButton;
    }
}

