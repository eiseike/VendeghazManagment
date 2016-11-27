namespace VendeghazManagment
{
    partial class FrmFoglalasManagmentUjFoglalas
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
            this.nudSzobaGyermekHely = new System.Windows.Forms.NumericUpDown();
            this.nudSzobaFelnotthely = new System.Windows.Forms.NumericUpDown();
            this.cboSzobaKiadhato = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSzobaNev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSzobaLstSzobaQuickFind = new System.Windows.Forms.TextBox();
            this.lstSzoba = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFoglalasUjSzobaSor = new System.Windows.Forms.Button();
            this.btnFoglalasUjSzobaSorElvetel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzobaGyermekHely)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzobaFelnotthely)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSzobaGyermekHely
            // 
            this.nudSzobaGyermekHely.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudSzobaGyermekHely.Location = new System.Drawing.Point(701, 238);
            this.nudSzobaGyermekHely.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.nudSzobaGyermekHely.Name = "nudSzobaGyermekHely";
            this.nudSzobaGyermekHely.Size = new System.Drawing.Size(120, 20);
            this.nudSzobaGyermekHely.TabIndex = 32;
            // 
            // nudSzobaFelnotthely
            // 
            this.nudSzobaFelnotthely.Location = new System.Drawing.Point(126, 58);
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
            this.nudSzobaFelnotthely.TabIndex = 33;
            this.nudSzobaFelnotthely.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboSzobaKiadhato
            // 
            this.cboSzobaKiadhato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSzobaKiadhato.FormattingEnabled = true;
            this.cboSzobaKiadhato.Location = new System.Drawing.Point(126, 96);
            this.cboSzobaKiadhato.Name = "cboSzobaKiadhato";
            this.cboSzobaKiadhato.Size = new System.Drawing.Size(121, 21);
            this.cboSzobaKiadhato.TabIndex = 30;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(752, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Mégsem";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(659, 366);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "Kész";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Gyermek hely:";
            // 
            // txtSzobaNev
            // 
            this.txtSzobaNev.Location = new System.Drawing.Point(126, 20);
            this.txtSzobaNev.Name = "txtSzobaNev";
            this.txtSzobaNev.Size = new System.Drawing.Size(121, 20);
            this.txtSzobaNev.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kiadható?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Felnőtt hely:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Szoba:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Azonosító:";
            // 
            // txtSzobaLstSzobaQuickFind
            // 
            this.txtSzobaLstSzobaQuickFind.Location = new System.Drawing.Point(311, 24);
            this.txtSzobaLstSzobaQuickFind.Name = "txtSzobaLstSzobaQuickFind";
            this.txtSzobaLstSzobaQuickFind.Size = new System.Drawing.Size(118, 20);
            this.txtSzobaLstSzobaQuickFind.TabIndex = 36;
            // 
            // lstSzoba
            // 
            this.lstSzoba.FormattingEnabled = true;
            this.lstSzoba.Location = new System.Drawing.Point(311, 50);
            this.lstSzoba.Name = "lstSzoba";
            this.lstSzoba.Size = new System.Drawing.Size(120, 95);
            this.lstSzoba.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Vendég:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(526, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(526, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Vendég +";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Vendég +";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnFoglalasUjSzobaSor
            // 
            this.btnFoglalasUjSzobaSor.Location = new System.Drawing.Point(39, 166);
            this.btnFoglalasUjSzobaSor.Name = "btnFoglalasUjSzobaSor";
            this.btnFoglalasUjSzobaSor.Size = new System.Drawing.Size(75, 23);
            this.btnFoglalasUjSzobaSor.TabIndex = 38;
            this.btnFoglalasUjSzobaSor.Text = "+";
            this.btnFoglalasUjSzobaSor.UseVisualStyleBackColor = true;
            this.btnFoglalasUjSzobaSor.Click += new System.EventHandler(this.btnFoglalasUjSzobaSor_Click);
            // 
            // btnFoglalasUjSzobaSorElvetel
            // 
            this.btnFoglalasUjSzobaSorElvetel.Location = new System.Drawing.Point(126, 166);
            this.btnFoglalasUjSzobaSorElvetel.Name = "btnFoglalasUjSzobaSorElvetel";
            this.btnFoglalasUjSzobaSorElvetel.Size = new System.Drawing.Size(75, 23);
            this.btnFoglalasUjSzobaSorElvetel.TabIndex = 38;
            this.btnFoglalasUjSzobaSorElvetel.Text = "-";
            this.btnFoglalasUjSzobaSorElvetel.UseVisualStyleBackColor = true;
            this.btnFoglalasUjSzobaSorElvetel.Click += new System.EventHandler(this.btnFoglalasUjSzobaSorElvetel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 195);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 222);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // FrmFoglalasManagmentUjFoglalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnFoglalasUjSzobaSorElvetel);
            this.Controls.Add(this.btnFoglalasUjSzobaSor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSzobaLstSzobaQuickFind);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lstSzoba);
            this.Controls.Add(this.nudSzobaGyermekHely);
            this.Controls.Add(this.nudSzobaFelnotthely);
            this.Controls.Add(this.cboSzobaKiadhato);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSzobaNev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmFoglalasManagmentUjFoglalas";
            ((System.ComponentModel.ISupportInitialize)(this.nudSzobaGyermekHely)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSzobaFelnotthely)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudSzobaGyermekHely;
        private System.Windows.Forms.NumericUpDown nudSzobaFelnotthely;
        private System.Windows.Forms.ComboBox cboSzobaKiadhato;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSzobaNev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSzobaLstSzobaQuickFind;
        private System.Windows.Forms.ListBox lstSzoba;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFoglalasUjSzobaSor;
        private System.Windows.Forms.Button btnFoglalasUjSzobaSorElvetel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}