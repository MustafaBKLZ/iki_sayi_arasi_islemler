
namespace iki_sayi_arasi_islemler
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ilk_sayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ikinci_sayi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_toplam_ver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_karelerinin_toplami = new System.Windows.Forms.Button();
            this.txt_us = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_asal_olanlari_ver = new System.Windows.Forms.Button();
            this.btn_sayilara_bolunebilenler = new System.Windows.Forms.Button();
            this.txt_bolenler = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlk Sayı";
            // 
            // txt_ilk_sayi
            // 
            this.txt_ilk_sayi.Location = new System.Drawing.Point(57, 25);
            this.txt_ilk_sayi.Name = "txt_ilk_sayi";
            this.txt_ilk_sayi.Size = new System.Drawing.Size(62, 20);
            this.txt_ilk_sayi.TabIndex = 1;
            this.txt_ilk_sayi.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İkinci Sayı";
            // 
            // txt_ikinci_sayi
            // 
            this.txt_ikinci_sayi.Location = new System.Drawing.Point(186, 25);
            this.txt_ikinci_sayi.Name = "txt_ikinci_sayi";
            this.txt_ikinci_sayi.Size = new System.Drawing.Size(62, 20);
            this.txt_ikinci_sayi.TabIndex = 3;
            this.txt_ikinci_sayi.Text = "10";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(344, 468);
            this.listBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sonuç";
            // 
            // btn_toplam_ver
            // 
            this.btn_toplam_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_toplam_ver.Location = new System.Drawing.Point(12, 93);
            this.btn_toplam_ver.Name = "btn_toplam_ver";
            this.btn_toplam_ver.Size = new System.Drawing.Size(289, 33);
            this.btn_toplam_ver.TabIndex = 6;
            this.btn_toplam_ver.Text = "Toplamını ver";
            this.btn_toplam_ver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_toplam_ver.UseVisualStyleBackColor = true;
            this.btn_toplam_ver.Click += new System.EventHandler(this.btn_toplam_ver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Girilen sayılar arasında kalan sayıların;";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(358, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 498);
            this.panel1.TabIndex = 8;
            // 
            // btn_karelerinin_toplami
            // 
            this.btn_karelerinin_toplami.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_karelerinin_toplami.Location = new System.Drawing.Point(13, 132);
            this.btn_karelerinin_toplami.Name = "btn_karelerinin_toplami";
            this.btn_karelerinin_toplami.Size = new System.Drawing.Size(289, 33);
            this.btn_karelerinin_toplami.TabIndex = 9;
            this.btn_karelerinin_toplami.Text = "Karelerinin Toplamını ver";
            this.btn_karelerinin_toplami.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_karelerinin_toplami.UseVisualStyleBackColor = true;
            this.btn_karelerinin_toplami.Click += new System.EventHandler(this.btn_karelerinin_toplami_Click);
            // 
            // txt_us
            // 
            this.txt_us.Location = new System.Drawing.Point(258, 139);
            this.txt_us.Name = "txt_us";
            this.txt_us.Size = new System.Drawing.Size(31, 20);
            this.txt_us.TabIndex = 2;
            this.txt_us.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Üs";
            // 
            // btn_asal_olanlari_ver
            // 
            this.btn_asal_olanlari_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_asal_olanlari_ver.Location = new System.Drawing.Point(12, 171);
            this.btn_asal_olanlari_ver.Name = "btn_asal_olanlari_ver";
            this.btn_asal_olanlari_ver.Size = new System.Drawing.Size(289, 33);
            this.btn_asal_olanlari_ver.TabIndex = 11;
            this.btn_asal_olanlari_ver.Text = "ASAL olanları ver";
            this.btn_asal_olanlari_ver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_asal_olanlari_ver.UseVisualStyleBackColor = true;
            this.btn_asal_olanlari_ver.Click += new System.EventHandler(this.btn_asal_olanlari_ver_Click);
            // 
            // btn_sayilara_bolunebilenler
            // 
            this.btn_sayilara_bolunebilenler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sayilara_bolunebilenler.Location = new System.Drawing.Point(12, 210);
            this.btn_sayilara_bolunebilenler.Name = "btn_sayilara_bolunebilenler";
            this.btn_sayilara_bolunebilenler.Size = new System.Drawing.Size(289, 33);
            this.btn_sayilara_bolunebilenler.TabIndex = 12;
            this.btn_sayilara_bolunebilenler.Text = "Yandaki sayılara bölünebilenler";
            this.btn_sayilara_bolunebilenler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sayilara_bolunebilenler.UseVisualStyleBackColor = true;
            this.btn_sayilara_bolunebilenler.Click += new System.EventHandler(this.btn_sayilara_bolunebilenler_Click);
            // 
            // txt_bolenler
            // 
            this.txt_bolenler.Location = new System.Drawing.Point(235, 217);
            this.txt_bolenler.Name = "txt_bolenler";
            this.txt_bolenler.Size = new System.Drawing.Size(65, 20);
            this.txt_bolenler.TabIndex = 13;
            this.txt_bolenler.Text = "2,3,4,5,7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 498);
            this.Controls.Add(this.txt_bolenler);
            this.Controls.Add(this.btn_sayilara_bolunebilenler);
            this.Controls.Add(this.btn_asal_olanlari_ver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_us);
            this.Controls.Add(this.btn_karelerinin_toplami);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_toplam_ver);
            this.Controls.Add(this.txt_ikinci_sayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ilk_sayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ilk_sayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ikinci_sayi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_toplam_ver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_karelerinin_toplami;
        private System.Windows.Forms.TextBox txt_us;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_asal_olanlari_ver;
        private System.Windows.Forms.Button btn_sayilara_bolunebilenler;
        private System.Windows.Forms.TextBox txt_bolenler;
    }
}

