namespace VendeghazManagment
{
    partial class FrmVendegManagmentUjVendeg
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVendegNev = new System.Windows.Forms.TextBox();
            this.txtVendegOkmanyAzonosito = new System.Windows.Forms.TextBox();
            this.cboVendegOkmanyTipus = new System.Windows.Forms.ComboBox();
            this.cboVendegNem = new System.Windows.Forms.ComboBox();
            this.dtpVendegSzuletesiDatum = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Okmány típus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Okmány száma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Születési dátum:";
            // 
            // txtVendegNev
            // 
            this.txtVendegNev.Location = new System.Drawing.Point(137, 15);
            this.txtVendegNev.Name = "txtVendegNev";
            this.txtVendegNev.Size = new System.Drawing.Size(121, 20);
            this.txtVendegNev.TabIndex = 0;
            // 
            // txtVendegOkmanyAzonosito
            // 
            this.txtVendegOkmanyAzonosito.Location = new System.Drawing.Point(137, 102);
            this.txtVendegOkmanyAzonosito.Name = "txtVendegOkmanyAzonosito";
            this.txtVendegOkmanyAzonosito.Size = new System.Drawing.Size(121, 20);
            this.txtVendegOkmanyAzonosito.TabIndex = 3;
            // 
            // cboVendegOkmanyTipus
            // 
            this.cboVendegOkmanyTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendegOkmanyTipus.FormattingEnabled = true;
            this.cboVendegOkmanyTipus.Location = new System.Drawing.Point(137, 73);
            this.cboVendegOkmanyTipus.Name = "cboVendegOkmanyTipus";
            this.cboVendegOkmanyTipus.Size = new System.Drawing.Size(121, 21);
            this.cboVendegOkmanyTipus.TabIndex = 2;
            // 
            // cboVendegNem
            // 
            this.cboVendegNem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendegNem.FormattingEnabled = true;
            this.cboVendegNem.Location = new System.Drawing.Point(137, 44);
            this.cboVendegNem.Name = "cboVendegNem";
            this.cboVendegNem.Size = new System.Drawing.Size(121, 21);
            this.cboVendegNem.TabIndex = 1;
            // 
            // dtpVendegSzuletesiDatum
            // 
            this.dtpVendegSzuletesiDatum.CustomFormat = "yyyy MM. dd.";
            this.dtpVendegSzuletesiDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVendegSzuletesiDatum.Location = new System.Drawing.Point(137, 131);
            this.dtpVendegSzuletesiDatum.Name = "dtpVendegSzuletesiDatum";
            this.dtpVendegSzuletesiDatum.Size = new System.Drawing.Size(121, 20);
            this.dtpVendegSzuletesiDatum.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(44, 161);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Kész";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(137, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Mégsem";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmVendegManagmentUjVendeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 215);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtpVendegSzuletesiDatum);
            this.Controls.Add(this.cboVendegNem);
            this.Controls.Add(this.cboVendegOkmanyTipus);
            this.Controls.Add(this.txtVendegOkmanyAzonosito);
            this.Controls.Add(this.txtVendegNev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmVendegManagmentUjVendeg";
            this.Text = "VendegManagmentUjVendeg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVendegNev;
        private System.Windows.Forms.TextBox txtVendegOkmanyAzonosito;
        private System.Windows.Forms.ComboBox cboVendegOkmanyTipus;
        private System.Windows.Forms.ComboBox cboVendegNem;
        private System.Windows.Forms.DateTimePicker dtpVendegSzuletesiDatum;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}