﻿namespace VendeghazManagment
{
    partial class fmtSzobaManagment
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
            this.btnModSzoba = new System.Windows.Forms.Button();
            this.lstSzoba = new System.Windows.Forms.ListBox();
            this.btnTorSzoba = new System.Windows.Forms.Button();
            this.btnUjSzoba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModSzoba
            // 
            this.btnModSzoba.Location = new System.Drawing.Point(144, 24);
            this.btnModSzoba.Name = "btnModSzoba";
            this.btnModSzoba.Size = new System.Drawing.Size(118, 23);
            this.btnModSzoba.TabIndex = 5;
            this.btnModSzoba.Text = "Vendég módosítása";
            this.btnModSzoba.UseVisualStyleBackColor = true;
            // 
            // lstSzoba
            // 
            this.lstSzoba.FormattingEnabled = true;
            this.lstSzoba.Location = new System.Drawing.Point(144, 116);
            this.lstSzoba.Name = "lstSzoba";
            this.lstSzoba.Size = new System.Drawing.Size(120, 95);
            this.lstSzoba.TabIndex = 6;
            // 
            // btnTorSzoba
            // 
            this.btnTorSzoba.Location = new System.Drawing.Point(146, 217);
            this.btnTorSzoba.Name = "btnTorSzoba";
            this.btnTorSzoba.Size = new System.Drawing.Size(118, 23);
            this.btnTorSzoba.TabIndex = 7;
            this.btnTorSzoba.Text = "Vendég törlése";
            this.btnTorSzoba.UseVisualStyleBackColor = true;
            // 
            // btnUjSzoba
            // 
            this.btnUjSzoba.Location = new System.Drawing.Point(20, 23);
            this.btnUjSzoba.Name = "btnUjSzoba";
            this.btnUjSzoba.Size = new System.Drawing.Size(118, 23);
            this.btnUjSzoba.TabIndex = 4;
            this.btnUjSzoba.Text = "Új vendég hozzáadása";
            this.btnUjSzoba.UseVisualStyleBackColor = true;
            // 
            // fmtSzobaManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnModSzoba);
            this.Controls.Add(this.lstSzoba);
            this.Controls.Add(this.btnTorSzoba);
            this.Controls.Add(this.btnUjSzoba);
            this.Name = "fmtSzobaManagment";
            this.Text = "fmtSzobaManagment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModSzoba;
        private System.Windows.Forms.ListBox lstSzoba;
        private System.Windows.Forms.Button btnTorSzoba;
        private System.Windows.Forms.Button btnUjSzoba;
    }
}