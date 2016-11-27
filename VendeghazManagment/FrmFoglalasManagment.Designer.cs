namespace VendeghazManagment
{
    partial class FrmFoglalasManagment
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
            this.txtFoglalasLstSzobaQuickFind = new System.Windows.Forms.TextBox();
            this.btnModFoglalas = new System.Windows.Forms.Button();
            this.lstFoglalas = new System.Windows.Forms.ListBox();
            this.btnTorFoglalas = new System.Windows.Forms.Button();
            this.btnUjFoglalas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFoglalasLstSzobaQuickFind
            // 
            this.txtFoglalasLstSzobaQuickFind.Location = new System.Drawing.Point(144, 90);
            this.txtFoglalasLstSzobaQuickFind.Name = "txtFoglalasLstSzobaQuickFind";
            this.txtFoglalasLstSzobaQuickFind.Size = new System.Drawing.Size(118, 20);
            this.txtFoglalasLstSzobaQuickFind.TabIndex = 13;
            // 
            // btnModFoglalas
            // 
            this.btnModFoglalas.Location = new System.Drawing.Point(144, 24);
            this.btnModFoglalas.Name = "btnModFoglalas";
            this.btnModFoglalas.Size = new System.Drawing.Size(118, 23);
            this.btnModFoglalas.TabIndex = 10;
            this.btnModFoglalas.Text = "Foglalás módosítása";
            this.btnModFoglalas.UseVisualStyleBackColor = true;
            // 
            // lstFoglalas
            // 
            this.lstFoglalas.FormattingEnabled = true;
            this.lstFoglalas.Location = new System.Drawing.Point(144, 116);
            this.lstFoglalas.Name = "lstFoglalas";
            this.lstFoglalas.Size = new System.Drawing.Size(120, 95);
            this.lstFoglalas.TabIndex = 11;
            // 
            // btnTorFoglalas
            // 
            this.btnTorFoglalas.Location = new System.Drawing.Point(146, 217);
            this.btnTorFoglalas.Name = "btnTorFoglalas";
            this.btnTorFoglalas.Size = new System.Drawing.Size(118, 23);
            this.btnTorFoglalas.TabIndex = 12;
            this.btnTorFoglalas.Text = "Foglalás törlése";
            this.btnTorFoglalas.UseVisualStyleBackColor = true;
            // 
            // btnUjFoglalas
            // 
            this.btnUjFoglalas.Location = new System.Drawing.Point(20, 23);
            this.btnUjFoglalas.Name = "btnUjFoglalas";
            this.btnUjFoglalas.Size = new System.Drawing.Size(118, 23);
            this.btnUjFoglalas.TabIndex = 9;
            this.btnUjFoglalas.Text = "Új foglalás hozzáadása";
            this.btnUjFoglalas.UseVisualStyleBackColor = true;
            this.btnUjFoglalas.Click += new System.EventHandler(this.btnUjFoglalas_Click);
            // 
            // FrmFoglalasManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtFoglalasLstSzobaQuickFind);
            this.Controls.Add(this.btnModFoglalas);
            this.Controls.Add(this.lstFoglalas);
            this.Controls.Add(this.btnTorFoglalas);
            this.Controls.Add(this.btnUjFoglalas);
            this.Name = "FrmFoglalasManagment";
            this.Text = "FrmFoglalasManagment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFoglalasLstSzobaQuickFind;
        private System.Windows.Forms.Button btnModFoglalas;
        private System.Windows.Forms.ListBox lstFoglalas;
        private System.Windows.Forms.Button btnTorFoglalas;
        private System.Windows.Forms.Button btnUjFoglalas;
    }
}