
namespace banka_uygulaması_v2
{
    partial class Ticari_İşlemler
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
            this.txtHesapno.Location = new System.Drawing.Point(137, 136);
            this.txtHesapno.Name = "txtHesapno";
            this.txtHesapno.Size = new System.Drawing.Size(100, 20);
            this.txtHesapno.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Hesap No :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(137, 84);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Ad :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(137, 110);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Soyad :";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(137, 162);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtBakiye.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Bakiye :";
            // 
            // btnÖzet
            // 
            this.btnÖzet.Location = new System.Drawing.Point(272, 261);
            this.btnÖzet.Name = "btnÖzet";
            this.btnÖzet.Size = new System.Drawing.Size(174, 40);
            this.btnÖzet.TabIndex = 51;
            this.btnÖzet.Text = "Hesap Özeti";
            this.btnÖzet.UseVisualStyleBackColor = true;
            this.btnÖzet.Click += new System.EventHandler(this.btnÖzet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(214, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "İşlemler Ekranı";
            // 
            // btnHavale
            // 
            this.btnHavale.Location = new System.Drawing.Point(272, 201);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(174, 40);
            this.btnHavale.TabIndex = 49;
            this.btnHavale.Text = "Havale Yapma";
            this.btnHavale.UseVisualStyleBackColor = true;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // btnYatırma
            // 
            this.btnYatırma.Location = new System.Drawing.Point(272, 143);
            this.btnYatırma.Name = "btnYatırma";
            this.btnYatırma.Size = new System.Drawing.Size(174, 40);
            this.btnYatırma.TabIndex = 48;
            this.btnYatırma.Text = "Para Yatırma";
            this.btnYatırma.UseVisualStyleBackColor = true;
            this.btnYatırma.Click += new System.EventHandler(this.btnYatırma_Click);
            // 
            // btnÇekme
            // 
            this.btnÇekme.Location = new System.Drawing.Point(272, 83);
            this.btnÇekme.Name = "btnÇekme";
            this.btnÇekme.Size = new System.Drawing.Size(174, 40);
            this.btnÇekme.TabIndex = 47;
            this.btnÇekme.Text = "Para Çekme";
            this.btnÇekme.UseVisualStyleBackColor = true;
            this.btnÇekme.Click += new System.EventHandler(this.btnÇekme_Click);
            // 
            // Ticari_İşlemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 350);
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
            this.Name = "Ticari_İşlemler";
            this.Text = "Ticari_İşlemler";
            this.Load += new System.EventHandler(this.Ticari_İşlemler_Load);
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