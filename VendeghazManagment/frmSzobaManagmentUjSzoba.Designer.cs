namespace VendeghazManagment
{
    partial class FrmSzobaManagmentUjSzoba
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtSzobaNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSzobaEmelet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSzobaFelnotthely = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSzobaGyermekHely = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSzobaKiadhato = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSzobaMegjegyzes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzobaFelnotthely)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzobaGyermekHely)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(124, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Mégsem";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(31, 289);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "Kész";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSzobaNev
            // 
            this.txtSzobaNev.Location = new System.Drawing.Point(124, 9);
            this.txtSzobaNev.Name = "txtSzobaNev";
            this.txtSzobaNev.Size = new System.Drawing.Size(121, 20);
            this.txtSzobaNev.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Emelet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Név:";
            // 
            // cboSzobaEmelet
            // 
            this.cboSzobaEmelet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSzobaEmelet.FormattingEnabled = true;
            this.cboSzobaEmelet.Location = new System.Drawing.Point(363, 16);
            this.cboSzobaEmelet.Name = "cboSzobaEmelet";
            this.cboSzobaEmelet.Size = new System.Drawing.Size(121, 21);
            this.cboSzobaEmelet.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Felnőtt hely:";
            // 
            // nudSzobaFelnotthely
            // 
            this.nudSzobaFelnotthely.Location = new System.Drawing.Point(124, 47);
            this.nudSzobaFelnotthely.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudSzobaFelnotthely.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSzobaFelnotthely.Name = "nudSzobaFelnotthely";
            this.nudSzobaFelnotthely.Size = new System.Drawing.Size(120, 20);
            this.nudSzobaFelnotthely.TabIndex = 19;
            this.nudSzobaFelnotthely.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gyermek hely:";
            // 
            // nudSzobaGyermekHely
            // 
            this.nudSzobaGyermekHely.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudSzobaGyermekHely.Location = new System.Drawing.Point(363, 49);
            this.nudSzobaGyermekHely.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudSzobaGyermekHely.Name = "nudSzobaGyermekHely";
            this.nudSzobaGyermekHely.Size = new System.Drawing.Size(120, 20);
            this.nudSzobaGyermekHely.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kiadható?";
            // 
            // cboSzobaKiadhato
            // 
            this.cboSzobaKiadhato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSzobaKiadhato.FormattingEnabled = true;
            this.cboSzobaKiadhato.Location = new System.Drawing.Point(124, 85);
            this.cboSzobaKiadhato.Name = "cboSzobaKiadhato";
            this.cboSzobaKiadhato.Size = new System.Drawing.Size(121, 21);
            this.cboSzobaKiadhato.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Megkegyzések:";
            // 
            // txtSzobaMegjegyzes
            // 
            this.txtSzobaMegjegyzes.Location = new System.Drawing.Point(125, 123);
            this.txtSzobaMegjegyzes.Multiline = true;
            this.txtSzobaMegjegyzes.Name = "txtSzobaMegjegyzes";
            this.txtSzobaMegjegyzes.Size = new System.Drawing.Size(358, 149);
            this.txtSzobaMegjegyzes.TabIndex = 20;
            // 
            // FrmSzobaManagmentUjSzoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 318);
            this.Controls.Add(this.txtSzobaMegjegyzes);
            this.Controls.Add(this.nudSzobaGyermekHely);
            this.Controls.Add(this.nudSzobaFelnotthely);
            this.Controls.Add(this.cboSzobaKiadhato);
            this.Controls.Add(this.cboSzobaEmelet);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSzobaNev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSzobaManagmentUjSzoba";
            this.Text = "FrmSzobaManagmentUjSzoba";
            ((System.ComponentModel.ISupportInitialize)(this.nudSzobaFelnotthely)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzobaGyermekHely)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtSzobaNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSzobaEmelet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSzobaFelnotthely;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSzobaGyermekHely;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSzobaKiadhato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSzobaMegjegyzes;
    }
}