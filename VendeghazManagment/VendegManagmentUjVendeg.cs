using System;
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
    public partial class VendegManagmentUjVendeg : Form
    {
        public VendegManagmentUjVendeg()
        {
            InitializeComponent();
            comboBoxOkmanyTipus.DataSource = Enum.GetValues(typeof(OkmanyTipus));
            comboBoxNem.DataSource = Enum.GetValues(typeof(Nem));
        }
    }
}
