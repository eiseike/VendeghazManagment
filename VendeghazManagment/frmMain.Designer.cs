namespace VendeghazManagment
{
    partial class FrmMain
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
            this.btnVendegek = new System.Windows.Forms.Button();
            this.btnSzobak = new System.Windows.Forms.Button();
            this.btnFoglalas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVendegek
            // 
            this.btnVendegek.Location = new System.Drawing.Point(12, 12);
            this.btnVendegek.Name = "btnVendegek";
            this.btnVendegek.Size = new System.Drawing.Size(160, 23);
            this.btnVendegek.TabIndex = 0;
            this.btnVendegek.Text = "Vendégek Managment";
            this.btnVendegek.UseVisualStyleBackColor = true;
            this.btnVendegek.Click += new System.EventHandler(this.btnVendegek_Click);
            // 
            // btnSzobak
            // 
            this.btnSzobak.Location = new System.Drawing.Point(178, 12);
            this.btnSzobak.Name = "btnSzobak";
            this.btnSzobak.Size = new System.Drawing.Size(160, 23);
            this.btnSzobak.TabIndex = 0;
            this.btnSzobak.Text = "Szobák Managment";
            this.btnSzobak.UseVisualStyleBackColor = true;
            this.btnSzobak.Click += new System.EventHandler(this.btnSzobak_Click);
            // 
            // btnFoglalas
            // 
            this.btnFoglalas.Location = new System.Drawing.Point(12, 238);
            this.btnFoglalas.Name = "btnFoglalas";
            this.btnFoglalas.Size = new System.Drawing.Size(160, 23);
            this.btnFoglalas.TabIndex = 0;
            this.btnFoglalas.Text = "Szobafoglalás";
            this.btnFoglalas.UseVisualStyleBackColor = true;
            this.btnFoglalas.Click += new System.EventHandler(this.btnFoglalas_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 817);
            this.Controls.Add(this.btnFoglalas);
            this.Controls.Add(this.btnSzobak);
            this.Controls.Add(this.btnVendegek);
            this.Name = "FrmMain";
            this.Text = "Szobafoglalás";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVendegek;
        private System.Windows.Forms.Button btnSzobak;
        private System.Windows.Forms.Button btnFoglalas;
    }
}

