namespace pys
{
    partial class Form2
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
            this.btnSube = new System.Windows.Forms.Button();
            this.btnYakitIsteme = new System.Windows.Forms.Button();
            this.btnYakitIslemleri = new System.Windows.Forms.Button();
            this.btnCalisanBilgiKaydetme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSube
            // 
            this.btnSube.Location = new System.Drawing.Point(123, 170);
            this.btnSube.Name = "btnSube";
            this.btnSube.Size = new System.Drawing.Size(162, 62);
            this.btnSube.TabIndex = 0;
            this.btnSube.Text = "Şube";
            this.btnSube.UseVisualStyleBackColor = true;
            this.btnSube.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnYakitIsteme
            // 
            this.btnYakitIsteme.Location = new System.Drawing.Point(123, 258);
            this.btnYakitIsteme.Name = "btnYakitIsteme";
            this.btnYakitIsteme.Size = new System.Drawing.Size(162, 62);
            this.btnYakitIsteme.TabIndex = 1;
            this.btnYakitIsteme.Text = "Yakıt İsteme";
            this.btnYakitIsteme.UseVisualStyleBackColor = true;
            this.btnYakitIsteme.Click += new System.EventHandler(this.btnYakitIsteme_Click);
            // 
            // btnYakitIslemleri
            // 
            this.btnYakitIslemleri.Location = new System.Drawing.Point(437, 170);
            this.btnYakitIslemleri.Name = "btnYakitIslemleri";
            this.btnYakitIslemleri.Size = new System.Drawing.Size(162, 62);
            this.btnYakitIslemleri.TabIndex = 2;
            this.btnYakitIslemleri.Text = "Yakıt Kabul";
            this.btnYakitIslemleri.UseVisualStyleBackColor = true;
            this.btnYakitIslemleri.Click += new System.EventHandler(this.btnYakitIslemleri_Click);
            // 
            // btnCalisanBilgiKaydetme
            // 
            this.btnCalisanBilgiKaydetme.Location = new System.Drawing.Point(437, 258);
            this.btnCalisanBilgiKaydetme.Name = "btnCalisanBilgiKaydetme";
            this.btnCalisanBilgiKaydetme.Size = new System.Drawing.Size(162, 62);
            this.btnCalisanBilgiKaydetme.TabIndex = 3;
            this.btnCalisanBilgiKaydetme.Text = "Çalışan Ekleme";
            this.btnCalisanBilgiKaydetme.UseVisualStyleBackColor = true;
            this.btnCalisanBilgiKaydetme.Click += new System.EventHandler(this.btnCalisanBilgiKaydetme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şube İşlemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yönetici İşlemleri";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalisanBilgiKaydetme);
            this.Controls.Add(this.btnYakitIslemleri);
            this.Controls.Add(this.btnYakitIsteme);
            this.Controls.Add(this.btnSube);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSube;
        private System.Windows.Forms.Button btnYakitIsteme;
        private System.Windows.Forms.Button btnYakitIslemleri;
        private System.Windows.Forms.Button btnCalisanBilgiKaydetme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}