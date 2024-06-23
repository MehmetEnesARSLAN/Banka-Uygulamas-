
namespace banka_uygulaması_v2
{
    partial class Havale_Yap
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
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnHavaleYap = new System.Windows.Forms.Button();
            this.txtKime = new System.Windows.Forms.TextBox();
            this.lbKime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHavaleTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHesapno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(332, 177);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(120, 23);
            this.btnİptal.TabIndex = 45;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // btnHavaleYap
            // 
            this.btnHavaleYap.Location = new System.Drawing.Point(186, 177);
            this.btnHavaleYap.Name = "btnHavaleYap";
            this.btnHavaleYap.Size = new System.Drawing.Size(120, 23);
            this.btnHavaleYap.TabIndex = 44;
            this.btnHavaleYap.Text = "HAVALE YAP";
            this.btnHavaleYap.UseVisualStyleBackColor = true;
            this.btnHavaleYap.Click += new System.EventHandler(this.btnHavaleYap_Click);
            // 
            // txtKime
            // 
            this.txtKime.Location = new System.Drawing.Point(425, 129);
            this.txtKime.Name = "txtKime";
            this.txtKime.Size = new System.Drawing.Size(100, 20);
            this.txtKime.TabIndex = 43;
            // 
            // lbKime
            // 
            this.lbKime.AutoSize = true;
            this.lbKime.Location = new System.Drawing.Point(383, 132);
            this.lbKime.Name = "lbKime";
            this.lbKime.Size = new System.Drawing.Size(36, 13);
            this.lbKime.TabIndex = 42;
            this.lbKime.Text = "Kime :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(328, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Havale Yap";
            // 
            // txtHavaleTutar
            // 
            this.txtHavaleTutar.Location = new System.Drawing.Point(425, 103);
            this.txtHavaleTutar.Name = "txtHavaleTutar";
            this.txtHavaleTutar.Size = new System.Drawing.Size(100, 20);
            this.txtHavaleTutar.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Havale Yapılacak Tutarı Girin :";
            // 
            // txtHesapno
            // 
            this.txtHesapno.Location = new System.Drawing.Point(105, 81);
            this.txtHesapno.Name = "txtHesapno";
            this.txtHesapno.Size = new System.Drawing.Size(100, 20);
            this.txtHesapno.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Hesap No :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(105, 29);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Ad :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(105, 55);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Soyad :";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(105, 107);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtBakiye.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Bakiye :";
            // 
            // Havale_Yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 258);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnHavaleYap);
            this.Controls.Add(this.txtKime);
            this.Controls.Add(this.lbKime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHavaleTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHesapno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label1);
            this.Name = "Havale_Yap";
            this.Text = "Havale_Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnHavaleYap;
        private System.Windows.Forms.TextBox txtKime;
        private System.Windows.Forms.Label lbKime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHavaleTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHesapno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label1;
    }
}