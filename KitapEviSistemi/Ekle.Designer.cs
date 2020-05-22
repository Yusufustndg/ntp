namespace KitapEviSistemi
{
    partial class Ekle
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
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkitaptürü = new System.Windows.Forms.TextBox();
            this.txtbasimtarih = new System.Windows.Forms.TextBox();
            this.txtyazarbilgileri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(145, 289);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(150, 75);
            this.kaydetbtn.TabIndex = 0;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Basım Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yazar Bilgileri";
            // 
            // txtkitaptürü
            // 
            this.txtkitaptürü.Location = new System.Drawing.Point(163, 246);
            this.txtkitaptürü.Name = "txtkitaptürü";
            this.txtkitaptürü.Size = new System.Drawing.Size(114, 20);
            this.txtkitaptürü.TabIndex = 6;
            // 
            // txtbasimtarih
            // 
            this.txtbasimtarih.Location = new System.Drawing.Point(163, 212);
            this.txtbasimtarih.Name = "txtbasimtarih";
            this.txtbasimtarih.Size = new System.Drawing.Size(114, 20);
            this.txtbasimtarih.TabIndex = 7;
            // 
            // txtyazarbilgileri
            // 
            this.txtyazarbilgileri.Location = new System.Drawing.Point(163, 175);
            this.txtyazarbilgileri.Name = "txtyazarbilgileri";
            this.txtyazarbilgileri.Size = new System.Drawing.Size(114, 20);
            this.txtyazarbilgileri.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kitap Adı";
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Location = new System.Drawing.Point(163, 142);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(114, 20);
            this.txtkitapadi.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "KİTAP BİLGİLERİ";
            // 
            // Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtkitapadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtyazarbilgileri);
            this.Controls.Add(this.txtbasimtarih);
            this.Controls.Add(this.txtkitaptürü);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kaydetbtn);
            this.Name = "Ekle";
            this.Text = "Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkitaptürü;
        private System.Windows.Forms.TextBox txtbasimtarih;
        private System.Windows.Forms.TextBox txtyazarbilgileri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtkitap;
    }
}