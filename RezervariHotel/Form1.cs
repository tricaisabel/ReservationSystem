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
    public partial class Form1 : Form
    {

        ColectieRezervari rezervari = new ColectieRezervari();
        RezervareOnline r;
        public Form1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (dpCheckIn.Value.CompareTo(dpCheckOut.Value) >= 0)
                errorProvider1.SetError(dpCheckIn, "Data check-in inainte de data check-out");
            else if (dpCheckIn.Value.CompareTo(DateTime.Now) < 0)
                errorProvider1.SetError(dpCheckIn,"Nu se pot face rezervari in trecut");
            else if (dpCheckOut.Value.CompareTo(DateTime.Now) < 0)
                errorProvider1.SetError(dpCheckOut, "Nu se pot face rezervari in trecut");
            else
            try
                {
                    string nume = tbNume.Text;
                    string camera = tbCamera.Text;
                    string checkIn = dpCheckIn.Text;
                    string checkOut = dpCheckOut.Text;
                    string sPlata = cbPlata.Text;
                    bool plata=false;
                    if(sPlata=="da") plata=true;
                    r = new RezervareOnline(checkIn, checkOut, nume, camera,plata);
                    rezervari += r;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                tbNume.Text = "";
                tbCamera.Text = "";
                dpCheckIn.Text = "";
                dpCheckOut.Text = "";
                }
           
        }

        private void btAfisare_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(rezervari);
            frm.Show();
        }
    }
}
