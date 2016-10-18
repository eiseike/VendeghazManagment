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
            this.btnUjVendeg = new System.Windows.Forms.Button();
            this.lstVendeg = new System.Windows.Forms.ListBox();
            this.btnModVendeg = new System.Windows.Forms.Button();
            this.btnTorVendeg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUjVendeg
            // 
            this.btnUjVendeg.Location = new System.Drawing.Point(6, 12);
            this.btnUjVendeg.Name = "btnUjVendeg";
            this.btnUjVendeg.Size = new System.Drawing.Size(118, 23);
            this.btnUjVendeg.TabIndex = 0;
            this.btnUjVendeg.Text = "Új vendég hozzáadása";
            this.btnUjVendeg.UseVisualStyleBackColor = true;
            this.btnUjVendeg.Click += new System.EventHandler(this.btnUjVendeg_Click);
            // 
            // lstVendeg
            // 
            this.lstVendeg.FormattingEnabled = true;
            this.lstVendeg.Location = new System.Drawing.Point(130, 105);
            this.lstVendeg.Name = "lstVendeg";
            this.lstVendeg.Size = new System.Drawing.Size(120, 95);
            this.lstVendeg.TabIndex = 2;
            this.lstVendeg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVendeg_MouseDoubleClick);
            // 
            // btnModVendeg
            // 
            this.btnModVendeg.Location = new System.Drawing.Point(130, 13);
            this.btnModVendeg.Name = "btnModVendeg";
            this.btnModVendeg.Size = new System.Drawing.Size(118, 23);
            this.btnModVendeg.TabIndex = 1;
            this.btnModVendeg.Text = "Vendég módosítása";
            this.btnModVendeg.UseVisualStyleBackColor = true;
            this.btnModVendeg.Click += new System.EventHandler(this.btnModVendeg_Click);
            // 
            // btnTorVendeg
            // 
            this.btnTorVendeg.Location = new System.Drawing.Point(132, 206);
            this.btnTorVendeg.Name = "btnTorVendeg";
            this.btnTorVendeg.Size = new System.Drawing.Size(118, 23);
            this.btnTorVendeg.TabIndex = 3;
            this.btnTorVendeg.Text = "Vendég törlése";
            this.btnTorVendeg.UseVisualStyleBackColor = true;
            this.btnTorVendeg.Click += new System.EventHandler(this.btnTorVendeg_Click);
            // 
            // frmVendegManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnModVendeg);
            this.Controls.Add(this.lstVendeg);
            this.Controls.Add(this.btnTorVendeg);
            this.Controls.Add(this.btnUjVendeg);
            this.Name = "frmVendegManagment";
            this.Text = "VendegManagment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUjVendeg;
        private System.Windows.Forms.ListBox lstVendeg;
        private System.Windows.Forms.Button btnModVendeg;
        private System.Windows.Forms.Button btnTorVendeg;
    }
}