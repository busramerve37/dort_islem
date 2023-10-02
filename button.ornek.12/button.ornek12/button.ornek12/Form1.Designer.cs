namespace button.ornek12
{
    partial class lblCarpim
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
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblFark = new System.Windows.Forms.Label();
            this.lblCarpma = new System.Windows.Forms.Label();
            this.lblBolme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(24, 32);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(39, 13);
            this.lblSayi1.TabIndex = 0;
            this.lblSayi1.Text = "1. Sayı";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(24, 58);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(37, 13);
            this.lblSayi2.TabIndex = 1;
            this.lblSayi2.Text = "2. sayı";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(81, 24);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(81, 58);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(27, 110);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 59);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(288, 31);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(45, 13);
            this.lblToplam.TabIndex = 5;
            this.lblToplam.Text = "Toplam:";
            // 
            // lblFark
            // 
            this.lblFark.AutoSize = true;
            this.lblFark.Location = new System.Drawing.Point(288, 58);
            this.lblFark.Name = "lblFark";
            this.lblFark.Size = new System.Drawing.Size(31, 13);
            this.lblFark.TabIndex = 6;
            this.lblFark.Text = "Fark:";
            // 
            // lblCarpma
            // 
            this.lblCarpma.AutoSize = true;
            this.lblCarpma.Location = new System.Drawing.Point(291, 90);
            this.lblCarpma.Name = "lblCarpma";
            this.lblCarpma.Size = new System.Drawing.Size(46, 13);
            this.lblCarpma.TabIndex = 7;
            this.lblCarpma.Text = "Çarpma:";
            // 
            // lblBolme
            // 
            this.lblBolme.AutoSize = true;
            this.lblBolme.Location = new System.Drawing.Point(291, 119);
            this.lblBolme.Name = "lblBolme";
            this.lblBolme.Size = new System.Drawing.Size(39, 13);
            this.lblBolme.TabIndex = 8;
            this.lblBolme.Text = "Bölme:";
            // 
            // lblCarpim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 374);
            this.Controls.Add(this.lblBolme);
            this.Controls.Add(this.lblCarpma);
            this.Controls.Add(this.lblFark);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Name = "lblCarpim";
            this.Text = "2. Sayı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblFark;
        private System.Windows.Forms.Label lblCarpma;
        private System.Windows.Forms.Label lblBolme;
    }
}

