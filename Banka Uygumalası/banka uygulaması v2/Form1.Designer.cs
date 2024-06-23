
namespace banka_uygulaması_v2
{
    partial class frmBankaUygulaması
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bireyselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticariToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bireyselToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ticariToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.girişYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişYapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişYapToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bireyselToolStripMenuItem,
            this.ticariToolStripMenuItem,
            this.ticariToolStripMenuItem1,
            this.personelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bireyselToolStripMenuItem
            // 
            this.bireyselToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bireyselToolStripMenuItem1,
            this.ticariToolStripMenuItem2});
            this.bireyselToolStripMenuItem.Name = "bireyselToolStripMenuItem";
            this.bireyselToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.bireyselToolStripMenuItem.Text = "Hesap Oluştur";
            // 
            // ticariToolStripMenuItem
            // 
            this.ticariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişYapToolStripMenuItem});
            this.ticariToolStripMenuItem.Name = "ticariToolStripMenuItem";
            this.ticariToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ticariToolStripMenuItem.Text = "Bireysel";
            // 
            // ticariToolStripMenuItem1
            // 
            this.ticariToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişYapToolStripMenuItem1});
            this.ticariToolStripMenuItem1.Name = "ticariToolStripMenuItem1";
            this.ticariToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.ticariToolStripMenuItem1.Text = "Ticari";
            // 
            // bireyselToolStripMenuItem1
            // 
            this.bireyselToolStripMenuItem1.Name = "bireyselToolStripMenuItem1";
            this.bireyselToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.bireyselToolStripMenuItem1.Text = "Bireysel";
            this.bireyselToolStripMenuItem1.Click += new System.EventHandler(this.bireyselToolStripMenuItem1_Click);
            // 
            // ticariToolStripMenuItem2
            // 
            this.ticariToolStripMenuItem2.Name = "ticariToolStripMenuItem2";
            this.ticariToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.ticariToolStripMenuItem2.Text = "Ticari";
            this.ticariToolStripMenuItem2.Click += new System.EventHandler(this.ticariToolStripMenuItem2_Click);
            // 
            // girişYapToolStripMenuItem
            // 
            this.girişYapToolStripMenuItem.Name = "girişYapToolStripMenuItem";
            this.girişYapToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.girişYapToolStripMenuItem.Text = "Giriş Yap";
            this.girişYapToolStripMenuItem.Click += new System.EventHandler(this.girişYapToolStripMenuItem_Click);
            // 
            // girişYapToolStripMenuItem1
            // 
            this.girişYapToolStripMenuItem1.Name = "girişYapToolStripMenuItem1";
            this.girişYapToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.girişYapToolStripMenuItem1.Text = "Giriş Yap";
            this.girişYapToolStripMenuItem1.Click += new System.EventHandler(this.girişYapToolStripMenuItem1_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişYapToolStripMenuItem2});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // girişYapToolStripMenuItem2
            // 
            this.girişYapToolStripMenuItem2.Name = "girişYapToolStripMenuItem2";
            this.girişYapToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.girişYapToolStripMenuItem2.Text = "Giriş Yap";
            this.girişYapToolStripMenuItem2.Click += new System.EventHandler(this.girişYapToolStripMenuItem2_Click);
            // 
            // frmBankaUygulaması
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 397);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBankaUygulaması";
            this.Text = "Banka Uygulaması";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bireyselToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bireyselToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ticariToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ticariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticariToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem girişYapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişYapToolStripMenuItem2;
    }
}

