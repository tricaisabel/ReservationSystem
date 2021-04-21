using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervariHotel
{
    public partial class Form2 : Form
    {
        ColectieRezervari colectie=new ColectieRezervari();
        public Form2(ColectieRezervari c)
        {
            InitializeComponent();
            colectie = c;
            tbRezervari.Text = c.ToString();
        }

        private void btSalvare_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "(*.txt)|*.txt";
            if(svd.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(svd.FileName);
                sw.WriteLine(colectie.ToString());
                sw.Close();
                MessageBox.Show("Salvat cu succes!");
            }
        }

        private void brCitire_Click(object sender, EventArgs e)
        {
            OpenFileDialog svd = new OpenFileDialog();
            svd.Filter = "(*.txt)|*.txt";
            if (svd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(svd.FileName);
                tbRezervari.Clear();
                tbRezervari.Text += "Citit din fisierul" + svd.FileName + Environment.NewLine;
                tbRezervari.Text += sr.ReadToEnd();
                sr.Close();
                MessageBox.Show("Citire cu succes!");
            }
        }

        private void brSerializare_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fileStream, colectie);
            fileStream.Close();
            MessageBox.Show("Serializare cu succes!");
        }

        private void btDeserializare_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            colectie=(ColectieRezervari)bf.Deserialize(fileStream);

            tbRezervari.Clear();
            tbRezervari.Text += "Obiecte deserializate din fisier.dat" + Environment.NewLine;
            string result = "";
            foreach(RezervareOnline r in colectie.Rezervari)
            {
                result += r.ToString() + Environment.NewLine;
            }
            tbRezervari.Text += result;
            fileStream.Close();
            MessageBox.Show("Deserializare cu succes!");
        }

        private void btSalvare_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void stergereTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbRezervari.Text = "";
        }

        private void salvareTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btSalvare_Click(sender,e);
        }

        private void rezervareNouaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cam nasol");
        }

        private void vizualizareListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(colectie);
            frm.Show();

        }

        private void vizualizareArboreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4(colectie);
            frm.Show();
        }

        private void desenareGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5(colectie);
            frm.Show();
        }
    }
}
