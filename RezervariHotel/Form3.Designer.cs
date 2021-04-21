
namespace RezervariHotel
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCamera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPlata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinVizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinMemorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinVizualizareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dinMemorieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cId,
            this.cNume,
            this.cCamera,
            this.cCheckIn,
            this.cCheckOut,
            this.cPlata});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(42, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1042, 309);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cId
            // 
            this.cId.Text = "Id";
            // 
            // cNume
            // 
            this.cNume.Text = "Nume";
            this.cNume.Width = 91;
            // 
            // cCamera
            // 
            this.cCamera.Text = "Camera";
            this.cCamera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cCamera.Width = 87;
            // 
            // cCheckIn
            // 
            this.cCheckIn.Text = "Check In";
            this.cCheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cCheckIn.Width = 176;
            // 
            // cCheckOut
            // 
            this.cCheckOut.Text = "Check Out";
            this.cCheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cCheckOut.Width = 196;
            // 
            // cPlata
            // 
            this.cPlata.Text = "Platit";
            this.cPlata.Width = 66;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergereToolStripMenuItem,
            this.editareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 68);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dinVizualizareToolStripMenuItem,
            this.dinMemorieToolStripMenuItem});
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.stergereToolStripMenuItem.Text = "Stergere";
            // 
            // dinVizualizareToolStripMenuItem
            // 
            this.dinVizualizareToolStripMenuItem.Name = "dinVizualizareToolStripMenuItem";
            this.dinVizualizareToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.dinVizualizareToolStripMenuItem.Text = "din vizualizare";
            this.dinVizualizareToolStripMenuItem.Click += new System.EventHandler(this.dinVizualizareToolStripMenuItem_Click);
            // 
            // dinMemorieToolStripMenuItem
            // 
            this.dinMemorieToolStripMenuItem.Name = "dinMemorieToolStripMenuItem";
            this.dinMemorieToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.dinMemorieToolStripMenuItem.Text = "din memorie";
            this.dinMemorieToolStripMenuItem.Click += new System.EventHandler(this.dinMemorieToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dinVizualizareToolStripMenuItem1,
            this.dinMemorieToolStripMenuItem1});
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(149, 32);
            this.editareToolStripMenuItem.Text = "Editare";
            // 
            // dinVizualizareToolStripMenuItem1
            // 
            this.dinVizualizareToolStripMenuItem1.Name = "dinVizualizareToolStripMenuItem1";
            this.dinVizualizareToolStripMenuItem1.Size = new System.Drawing.Size(224, 34);
            this.dinVizualizareToolStripMenuItem1.Text = "din vizualizare";
            this.dinVizualizareToolStripMenuItem1.Click += new System.EventHandler(this.dinVizualizareToolStripMenuItem1_Click);
            // 
            // dinMemorieToolStripMenuItem1
            // 
            this.dinMemorieToolStripMenuItem1.Name = "dinMemorieToolStripMenuItem1";
            this.dinMemorieToolStripMenuItem1.Size = new System.Drawing.Size(224, 34);
            this.dinMemorieToolStripMenuItem1.Text = "din memorie";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 450);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cNume;
        private System.Windows.Forms.ColumnHeader cCamera;
        private System.Windows.Forms.ColumnHeader cCheckIn;
        private System.Windows.Forms.ColumnHeader cCheckOut;
        private System.Windows.Forms.ColumnHeader cPlata;
        private System.Windows.Forms.ColumnHeader cId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinVizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinMemorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinVizualizareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dinMemorieToolStripMenuItem1;
    }
}