﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendeghazManagment
{
    public partial class frmVendegManagment : Form
    {
        public frmVendegManagment()
        {
            InitializeComponent();

            lstVendeg.DataSource = DBFeladatok.VendegDataTable();
            lstVendeg.DisplayMember = "nev";
            lstVendeg.ValueMember = "id";
        }

        private void buttonUjVendegHozzaadasa_Click(object sender, EventArgs e)
        {
            FrmVendegManagmentUjVendeg vendegManagmentUjVendeg = new FrmVendegManagmentUjVendeg();

            if (vendegManagmentUjVendeg.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    DBFeladatok.SaveVendeg(vendegManagmentUjVendeg.Tarolt);
                    lstVendeg.DataSource = DBFeladatok.VendegDataTable();
                }
                catch (Exception ex)
                {
                    EasyLog.LogMessageToFile(ex.Message);
                    throw ex;
                }

                //refresh ha kinn vannak valahol az adatok

            }
        }

        private void lstVendeg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVendeg.SelectedIndex != 0)
            {
                var vendegManagmentUjVendeg = new FrmVendegManagmentUjVendeg((int)lstVendeg.SelectedValue);

                if (vendegManagmentUjVendeg.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        DBFeladatok.UpdateVendeg(lstVendeg.SelectedIndex, vendegManagmentUjVendeg.Tarolt);
                        lstVendeg.DataSource = DBFeladatok.VendegDataTable();
                    }
                    catch (Exception ex)
                    {
                        EasyLog.LogMessageToFile(ex.Message);
                        throw ex;
                    }

                    //refresh ha kinn vannak valahol az adatok
                }

            }
        }
    }
}
