namespace VendeghazManagment
{
    partial class frmVendegManagment
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
            this.buttonUjVendegHozzaadasa = new System.Windows.Forms.Button();
            this.lstVendeg = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonUjVendegHozzaadasa
            // 
            this.buttonUjVendegHozzaadasa.Location = new System.Drawing.Point(13, 13);
            this.buttonUjVendegHozzaadasa.Name = "buttonUjVendegHozzaadasa";
            this.buttonUjVendegHozzaadasa.Size = new System.Drawing.Size(75, 23);
            this.buttonUjVendegHozzaadasa.TabIndex = 0;
            this.buttonUjVendegHozzaadasa.Text = "Új vendég hozzáadása";
            this.buttonUjVendegHozzaadasa.UseVisualStyleBackColor = true;
            this.buttonUjVendegHozzaadasa.Click += new System.EventHandler(this.buttonUjVendegHozzaadasa_Click);
            // 
            // lstVendeg
            // 
            this.lstVendeg.FormattingEnabled = true;
            this.lstVendeg.Location = new System.Drawing.Point(47, 70);
            this.lstVendeg.Name = "lstVendeg";
            this.lstVendeg.Size = new System.Drawing.Size(120, 95);
            this.lstVendeg.TabIndex = 1;
            this.lstVendeg.SelectedIndexChanged += new System.EventHandler(this.lstVendeg_SelectedIndexChanged);
            // 
            // frmVendegManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstVendeg);
            this.Controls.Add(this.buttonUjVendegHozzaadasa);
            this.Name = "frmVendegManagment";
            this.Text = "VendegManagment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUjVendegHozzaadasa;
        private System.Windows.Forms.ListBox lstVendeg;
    }
}