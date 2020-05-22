namespace KitapEviSistemi
{
    partial class GirisEkranı
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
            this.GörList = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GörList
            // 
            this.GörList.Location = new System.Drawing.Point(58, 88);
            this.GörList.Name = "GörList";
            this.GörList.Size = new System.Drawing.Size(283, 189);
            this.GörList.TabIndex = 1;
            this.GörList.Text = "Kitap Listesi Görüntüleme";
            this.GörList.UseVisualStyleBackColor = true;
            this.GörList.Click += new System.EventHandler(this.GörList_Click);
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(397, 88);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(271, 189);
            this.EkleBtn.TabIndex = 2;
            this.EkleBtn.Text = "Kitap Ekleme";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.GörList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GörList;
        private System.Windows.Forms.Button EkleBtn;
    }
}

