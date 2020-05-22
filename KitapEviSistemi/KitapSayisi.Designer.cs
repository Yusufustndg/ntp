namespace KitapEviSistemi
{
    partial class KitapSayisi
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
            this.Adetbtn = new System.Windows.Forms.Button();
            this.txtkitapsayısı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Adetbtn
            // 
            this.Adetbtn.Location = new System.Drawing.Point(488, 169);
            this.Adetbtn.Name = "Adetbtn";
            this.Adetbtn.Size = new System.Drawing.Size(126, 35);
            this.Adetbtn.TabIndex = 15;
            this.Adetbtn.Text = "Adet Gir";
            this.Adetbtn.UseVisualStyleBackColor = true;
            this.Adetbtn.Click += new System.EventHandler(this.Adetbtn_Click);
            // 
            // txtkitapsayısı
            // 
            this.txtkitapsayısı.Location = new System.Drawing.Point(347, 177);
            this.txtkitapsayısı.Name = "txtkitapsayısı";
            this.txtkitapsayısı.Size = new System.Drawing.Size(114, 20);
            this.txtkitapsayısı.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kaç Adet Kitap Girmek İstiyorsunuz";
            // 
            // KitapSayisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Adetbtn);
            this.Controls.Add(this.txtkitapsayısı);
            this.Controls.Add(this.label1);
            this.Name = "KitapSayisi";
            this.Text = "KitapSayisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adetbtn;
        private System.Windows.Forms.TextBox txtkitapsayısı;
        private System.Windows.Forms.Label label1;
    }
}