namespace KitapEviSistemi
{
    partial class Listeleme
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
            this.dtkitap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtkitap)).BeginInit();
            this.SuspendLayout();
            // 
            // gridliste
            // 
            this.dtkitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtkitap.Location = new System.Drawing.Point(12, 12);
            this.dtkitap.Name = "gridliste";
            this.dtkitap.Size = new System.Drawing.Size(776, 426);
            this.dtkitap.TabIndex = 0;
            this.dtkitap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridliste_CellClick);
            // 
            // Listeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtkitap);
            this.Name = "Listeleme";
            this.Text = "Listeleme";
            ((System.ComponentModel.ISupportInitialize)(this.dtkitap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkitapsayısı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkitaptürü;
        private System.Windows.Forms.TextBox txtbasimtarih;
        private System.Windows.Forms.TextBox txtyazarbilgileri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Adetbtn;
        private System.Windows.Forms.DataGridView dtkitap;
    }
}