﻿
namespace banka_uygulaması_v2
{
    partial class Para_Yatırma
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
            this.btnYatır = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYatırTutar = new System.Windows.Forms.TextBox();
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
            this.btnİptal.Location = new System.Drawing.Point(308, 165);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(120, 23);
            this.btnİptal.TabIndex = 35;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // btnYatır
            // 
            this.btnYatır.Location = new System.Drawing.Point(162, 165);
            this.btnYatır.Name = "btnYatır";
            this.btnYatır.Size = new System.Drawing.Size(120, 23);
            this.btnYatır.TabIndex = 34;
            this.btnYatır.Text = "YATIR";
            this.btnYatır.UseVisualStyleBackColor = true;
            this.btnYatır.Click += new System.EventHandler(this.btnYatır_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(318, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Para Yatırma";
            // 
            // txtYatırTutar
            // 
            this.txtYatırTutar.Location = new System.Drawing.Point(384, 89);
            this.txtYatırTutar.Name = "txtYatırTutar";
            this.txtYatırTutar.Size = new System.Drawing.Size(100, 20);
            this.txtYatırTutar.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Yatırılacak Tutarı Girin :";
            // 
            // txtHesapno
            // 
            this.txtHesapno.Location = new System.Drawing.Point(95, 81);
            this.txtHesapno.Name = "txtHesapno";
            this.txtHesapno.Size = new System.Drawing.Size(100, 20);
            this.txtHesapno.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Hesap No :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(95, 29);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ad :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(95, 55);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Soyad :";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(95, 107);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtBakiye.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bakiye :";
            // 
            // Para_Yatırma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 255);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnYatır);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYatırTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHesapno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label1);
            this.Name = "Para_Yatırma";
            this.Text = "Para_Yatırma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnYatır;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYatırTutar;
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