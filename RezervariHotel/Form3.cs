using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervariHotel
{
    public partial class Form3 : Form
    {
        ColectieRezervari colectie = new ColectieRezervari();
        public Form3(ColectieRezervari c)
        {
            InitializeComponent();
            colectie = c;
            int id = 1;
            foreach (RezervareOnline r in colectie.Rezervari)
            {
                ListViewItem item = new ListViewItem(id.ToString());
                item.SubItems.Add(r.numeClient);
                item.SubItems.Add(r.nrCamera);
                item.SubItems.Add(r.CheckIn);
                item.SubItems.Add(r.CheckOut);
                item.SubItems.Add(r.Plata.ToString());
                listView1.Items.Add(item);
                id++;
            }

        }

        private void dinVizualizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.Items)
            {
                if (item.Selected) item.Remove();
            }
        }

        private void dinMemorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                    foreach(RezervareOnline r in colectie.Rezervari)
                    {
                        if (r.numeClient == item.SubItems[1].Text)
                        {
                            colectie.Rezervari.Remove(r);
                            MessageBox.Show(r.numeClient + " a fost stearsa din memorie!");
                            dinVizualizareToolStripMenuItem_Click(sender, e);
                            break;
                        }
                    }
            }
        }

        private void dinVizualizareToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
