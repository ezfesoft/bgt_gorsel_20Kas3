namespace bgt_gorsel_20Kas3
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(12, 70);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(208, 30);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Location = new System.Drawing.Point(12, 123);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(208, 30);
            this.txtParola.TabIndex = 4;
            this.txtParola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Parola:";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(12, 159);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(208, 55);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DURUM:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(69, 236);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(50, 31);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(237, 273);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDurum;
    }
}

