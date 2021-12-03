namespace ParlaklikAyari
{
    partial class ParlaklikAyari
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbParlaklikDeger = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblNot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(57, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(245, 21);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Bir Parlaklık Degeri Seç";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "0-100";
            // 
            // tbParlaklikDeger
            // 
            this.tbParlaklikDeger.Location = new System.Drawing.Point(129, 96);
            this.tbParlaklikDeger.Name = "tbParlaklikDeger";
            this.tbParlaklikDeger.Size = new System.Drawing.Size(100, 20);
            this.tbParlaklikDeger.TabIndex = 1;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.btnDegistir.Location = new System.Drawing.Point(94, 139);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(170, 29);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.Text = "Parlaklıgı Degistir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.Location = new System.Drawing.Point(284, 166);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(62, 9);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "by Kerem Zayim";
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNot.ForeColor = System.Drawing.Color.Red;
            this.lblNot.Location = new System.Drawing.Point(2, 168);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(19, 9);
            this.lblNot.TabIndex = 3;
            this.lblNot.Text = "Not:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 9);
            this.label2.TabIndex = 3;
            this.label2.Text = "Masaüstü Bilgisayarlarda Çalışmaz";
            // 
            // ParlaklikAyari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNot);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.tbParlaklikDeger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ParlaklikAyari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parlaklık Ayarı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbParlaklikDeger;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblNot;
        private System.Windows.Forms.Label label2;
    }
}

