namespace Uygulama21
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
            this.btnveribağla = new System.Windows.Forms.Button();
            this.listeVeriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnveribağla
            // 
            this.btnveribağla.Location = new System.Drawing.Point(207, 150);
            this.btnveribağla.Name = "btnveribağla";
            this.btnveribağla.Size = new System.Drawing.Size(58, 44);
            this.btnveribağla.TabIndex = 0;
            this.btnveribağla.Text = "Veri Bağla";
            this.btnveribağla.UseVisualStyleBackColor = true;
            this.btnveribağla.Click += new System.EventHandler(this.btnveribağla_Click);
            // 
            // listeVeriler
            // 
            this.listeVeriler.FormattingEnabled = true;
            this.listeVeriler.Location = new System.Drawing.Point(312, 150);
            this.listeVeriler.Name = "listeVeriler";
            this.listeVeriler.Size = new System.Drawing.Size(139, 147);
            this.listeVeriler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listeVeriler);
            this.Controls.Add(this.btnveribağla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnveribağla;
        private System.Windows.Forms.ListBox listeVeriler;
    }
}

