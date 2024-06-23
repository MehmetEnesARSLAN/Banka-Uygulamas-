
namespace banka_uygulaması_v2
{
    partial class bireysel_işlemler
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
            this.txtHesapno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnÖzet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHavale = new System.Windows.Forms.Button();
            this.btnYatırma = new System.Windows.Forms.Button();
            this.btnÇekme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHesapno
            // 
            this.txtHesapno.Location = new System.Drawing.Point(167, 142);
            this.txtHesapno.Name = "txtHesapno";
            this.txtHesapno.Size = new System.Drawing.Size(100, 20);
            this.txtHesapno.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Hesap No :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(167, 90);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ad :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(167, 116);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Soyad :";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(167, 168);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtBakiye.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Bakiye :";
            // 
            // btnÖzet
            // 
            this.btnÖzet.Location = new System.Drawing.Point(302, 267);
            this.btnÖzet.Name = "btnÖzet";
            this.btnÖzet.Size = new System.Drawing.Size(174, 40);
            this.btnÖzet.TabIndex = 38;
            this.btnÖzet.Text = "Hesap Özeti";
            this.btnÖzet.UseVisualStyleBackColor = true;
            this.btnÖzet.Click += new System.EventHandler(this.btnÖzet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(244, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "İşlemler Ekranı";
            // 
            // btnHavale
            // 
            this.btnHavale.Location = new System.Drawing.Point(302, 207);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(174, 40);
            this.btnHavale.TabIndex = 36;
            this.btnHavale.Text = "Havale Yapma";
            this.btnHavale.UseVisualStyleBackColor = true;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // btnYatırma
            // 
            this.btnYatırma.Location = new System.Drawing.Point(302, 149);
            this.btnYatırma.Name = "btnYatırma";
            this.btnYatırma.Size = new System.Drawing.Size(174, 40);
            this.btnYatırma.TabIndex = 35;
            this.btnYatırma.Text = "Para Yatırma";
            this.btnYatırma.UseVisualStyleBackColor = true;
            this.btnYatırma.Click += new System.EventHandler(this.btnYatırma_Click);
            // 
            // btnÇekme
            // 
            this.btnÇekme.Location = new System.Drawing.Point(302, 89);
            this.btnÇekme.Name = "btnÇekme";
            this.btnÇekme.Size = new System.Drawing.Size(174, 40);
            this.btnÇekme.TabIndex = 34;
            this.btnÇekme.Text = "Para Çekme";
            this.btnÇekme.UseVisualStyleBackColor = true;
            this.btnÇekme.Click += new System.EventHandler(this.btnÇekme_Click);
            // 
            // bireysel_işlemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 362);
            this.Controls.Add(this.txtHesapno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnÖzet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHavale);
            this.Controls.Add(this.btnYatırma);
            this.Controls.Add(this.btnÇekme);
            this.Name = "bireysel_işlemler";
            this.Text = "bireysel_işlemler";
            this.Load += new System.EventHandler(this.bireysel_işlemler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHesapno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnÖzet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.Button btnYatırma;
        private System.Windows.Forms.Button btnÇekme;
    }
}