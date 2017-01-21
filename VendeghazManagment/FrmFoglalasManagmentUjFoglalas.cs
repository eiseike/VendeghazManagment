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

    //letrehozunk egy foglalast sql-ben, es megtudjuk az ID-t, azt eltesszuk.

    //miniden szurke, csak a szoba es vendeg resz nem (?)

    //kivalaszthatunk egy vendeget, akihez rendeljuk az egeszet - vagy hozzaadunk egy uj vendeget, es kivalasztjuk.

    //kivalasztjuk a datumot mettol meddig. ez kiirja a szabad szobakat.

    //kivalasztjuk hany ember, ez kiirja a lehetseges szobakat.

    //kivalasztjuk a szobat.

    //beikszeljuk hany ember ker reggelit, ebedet.
     
    //elmentjuk a foglalast a vendeghez.
    

    //Sikeres mentesnel, ha meg nincs , elnevezzuk a foglalast valami random azonositoval, es azt is beleirjuk a tablaba.



    public partial class FrmFoglalasManagmentUjFoglalas : Form
    {

        private TextBox[] textBoxs1;    // Array of textboxes
        private TextBox[] textBoxs2;    // Array of textboxes
        private TextBox[] textBoxs3;    // Array of textboxes
        private Button[] buttons1;
        private int count = -1;
        private int rowIndex = 0;

        private int max_row = 8;


        public FrmFoglalasManagmentUjFoglalas()
        {
            InitializeComponent();
            initialize_controls_array();
        }

        private void initialize_controls_array()
        {
            textBoxs1 = new TextBox[max_row];
            textBoxs2 = new TextBox[max_row];
            textBoxs3 = new TextBox[max_row];
            buttons1 = new Button[max_row];

        }

        private void btnFoglalasUjSzobaSor_Click(object sender, EventArgs e)
        {
            if (count == max_row - 1)
            {
                MessageBox.Show("Maximum of " + max_row + " rows can be added");
                return;
            }
            else
            {
                count++;

                textBoxs1[count] = new TextBox();
                textBoxs1[count].Dock = DockStyle.None;
                textBoxs1[count].Anchor = AnchorStyles.None;

                textBoxs2[count] = new TextBox();
                textBoxs2[count].Dock = DockStyle.None;
                textBoxs2[count].Anchor = AnchorStyles.None;

                textBoxs3[count] = new TextBox();
                textBoxs3[count].Dock = DockStyle.None;
                textBoxs3[count].Anchor = AnchorStyles.None;

                
                this.tableLayoutPanel1.Controls.Add(this.textBoxs1[count], 0, count);
                this.tableLayoutPanel1.Controls.Add(this.textBoxs2[count], 1, count);
                this.tableLayoutPanel1.Controls.Add(this.textBoxs3[count], 2, count);
                textBoxs1[count].Text = (count).ToString();
               

            }
        }

        private void btnFoglalasUjSzobaSorElvetel_Click(object sender, EventArgs e)
        {
            if (count > -1)  // Deleting one row at a time
            {
                this.tableLayoutPanel1.Controls.Remove(textBoxs1[count]);
                this.tableLayoutPanel1.Controls.Remove(textBoxs2[count]);
                this.tableLayoutPanel1.Controls.Remove(textBoxs3[count]);

                count--;
            }
        }
    }
}
