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
    public partial class Form4 : Form
    {
        ColectieRezervari colectie = new ColectieRezervari();
        public Form4(ColectieRezervari c)
        {
            InitializeComponent();
            colectie = c;
            TreeNode parinte = new TreeNode("Rezervari");
            treeView1.Nodes.Add(parinte);
            foreach(RezervareOnline r in colectie.Rezervari)
            {
                TreeNode copil = new TreeNode(r.numeClient);
                parinte.Nodes.Add(copil);
                TreeNode nepot1 = new TreeNode(r.nrCamera);
                copil.Nodes.Add(nepot1);
                TreeNode nepot2 = new TreeNode(r.CheckIn);
                copil.Nodes.Add(nepot2);
                TreeNode nepot3 = new TreeNode(r.CheckOut);
                copil.Nodes.Add(nepot3);
                TreeNode nepot4 = new TreeNode(r.Plata.ToString());
                copil.Nodes.Add(nepot4);

            }
            treeView1.ExpandAll();
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count > 0)
            {
                TreeNode nodSelectat = treeView1.SelectedNode;
                if (nodSelectat.NextNode != null)
                    nodSelectat = treeView1.SelectedNode.NextNode;
                else
                    if (nodSelectat.PrevNode != null)
                    nodSelectat = treeView1.SelectedNode.PrevNode;
                treeView1.SelectedNode.Remove();
                treeView1.SelectedNode = nodSelectat;

            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            treeView1.SelectedNode.BackColor=Color.BlueViolet;
        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbEditare.Text != "") treeView1.SelectedNode.Text = tbEditare.Text;
            else errorProvider1.SetError(tbEditare, "Introduceti valoarea cu care editati prima oara!");
        }
    }
}
