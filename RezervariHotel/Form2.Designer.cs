
namespace RezervariHotel
{
    partial class Form2
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
            this.tbRezervari = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergereTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btSalvare = new System.Windows.Forms.Button();
            this.brCitire = new System.Windows.Forms.Button();
            this.brSerializare = new System.Windows.Forms.Button();
            this.btDeserializare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rezervareNouaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareArboreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenareGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbRezervari
            // 
            this.tbRezervari.ContextMenuStrip = this.contextMenuStrip1;
            this.tbRezervari.Location = new System.Drawing.Point(75, 77);
            this.tbRezervari.Multiline = true;
            this.tbRezervari.Name = "tbRezervari";
            this.tbRezervari.ReadOnly = true;
            this.tbRezervari.Size = new System.Drawing.Size(636, 225);
            this.tbRezervari.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergereTextToolStripMenuItem,
            this.salvareTextToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 68);
            // 
            // stergereTextToolStripMenuItem
            // 
            this.stergereTextToolStripMenuItem.Name = "stergereTextToolStripMenuItem";
            this.stergereTextToolStripMenuItem.Size = new System.Drawing.Size(183, 32);
            this.stergereTextToolStripMenuItem.Text = "Stergere text";
            this.stergereTextToolStripMenuItem.Click += new System.EventHandler(this.stergereTextToolStripMenuItem_Click);
            // 
            // salvareTextToolStripMenuItem
            // 
            this.salvareTextToolStripMenuItem.Name = "salvareTextToolStripMenuItem";
            this.salvareTextToolStripMenuItem.Size = new System.Drawing.Size(183, 32);
            this.salvareTextToolStripMenuItem.Text = "Salvare text";
            this.salvareTextToolStripMenuItem.Click += new System.EventHandler(this.salvareTextToolStripMenuItem_Click);
            // 
            // btSalvare
            // 
            this.btSalvare.Location = new System.Drawing.Point(75, 318);
            this.btSalvare.Name = "btSalvare";
            this.btSalvare.Size = new System.Drawing.Size(137, 42);
            this.btSalvare.TabIndex = 1;
            this.btSalvare.Text = "&Salvare text";
            this.btSalvare.UseVisualStyleBackColor = true;
            this.btSalvare.Click += new System.EventHandler(this.btSalvare_Click);
            this.btSalvare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btSalvare_KeyPress);
            // 
            // brCitire
            // 
            this.brCitire.Location = new System.Drawing.Point(231, 318);
            this.brCitire.Name = "brCitire";
            this.brCitire.Size = new System.Drawing.Size(137, 42);
            this.brCitire.TabIndex = 2;
            this.brCitire.Text = "&Citire text";
            this.brCitire.UseVisualStyleBackColor = true;
            this.brCitire.Click += new System.EventHandler(this.brCitire_Click);
            // 
            // brSerializare
            // 
            this.brSerializare.Location = new System.Drawing.Point(414, 318);
            this.brSerializare.Name = "brSerializare";
            this.brSerializare.Size = new System.Drawing.Size(137, 42);
            this.brSerializare.TabIndex = 3;
            this.brSerializare.Text = "Serializare";
            this.brSerializare.UseVisualStyleBackColor = true;
            this.brSerializare.Click += new System.EventHandler(this.brSerializare_Click);
            // 
            // btDeserializare
            // 
            this.btDeserializare.Location = new System.Drawing.Point(574, 318);
            this.btDeserializare.Name = "btDeserializare";
            this.btDeserializare.Size = new System.Drawing.Size(137, 42);
            this.btDeserializare.TabIndex = 4;
            this.btDeserializare.Text = "Deserializare";
            this.btDeserializare.UseVisualStyleBackColor = true;
            this.btDeserializare.Click += new System.EventHandler(this.btDeserializare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Camera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Check-In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Check-Out";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervareNouaToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.vizualizareListaToolStripMenuItem,
            this.vizualizareArboreToolStripMenuItem,
            this.desenareGraficToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rezervareNouaToolStripMenuItem
            // 
            this.rezervareNouaToolStripMenuItem.Name = "rezervareNouaToolStripMenuItem";
            this.rezervareNouaToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.rezervareNouaToolStripMenuItem.Text = "Rezervare noua";
            this.rezervareNouaToolStripMenuItem.Click += new System.EventHandler(this.rezervareNouaToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.helpToolStripMenuItem.Text = "Ajutor?";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // vizualizareListaToolStripMenuItem
            // 
            this.vizualizareListaToolStripMenuItem.Name = "vizualizareListaToolStripMenuItem";
            this.vizualizareListaToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.vizualizareListaToolStripMenuItem.Text = "Vizualizare lista";
            this.vizualizareListaToolStripMenuItem.Click += new System.EventHandler(this.vizualizareListaToolStripMenuItem_Click);
            // 
            // vizualizareArboreToolStripMenuItem
            // 
            this.vizualizareArboreToolStripMenuItem.Name = "vizualizareArboreToolStripMenuItem";
            this.vizualizareArboreToolStripMenuItem.Size = new System.Drawing.Size(167, 29);
            this.vizualizareArboreToolStripMenuItem.Text = "Vizualizare arbore";
            this.vizualizareArboreToolStripMenuItem.Click += new System.EventHandler(this.vizualizareArboreToolStripMenuItem_Click);
            // 
            // desenareGraficToolStripMenuItem
            // 
            this.desenareGraficToolStripMenuItem.Name = "desenareGraficToolStripMenuItem";
            this.desenareGraficToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.desenareGraficToolStripMenuItem.Text = "Desenare grafic";
            this.desenareGraficToolStripMenuItem.Click += new System.EventHandler(this.desenareGraficToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDeserializare);
            this.Controls.Add(this.brSerializare);
            this.Controls.Add(this.brCitire);
            this.Controls.Add(this.btSalvare);
            this.Controls.Add(this.tbRezervari);
            this.Name = "Form2";
            this.Text = "Form2";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRezervari;
        private System.Windows.Forms.Button btSalvare;
        private System.Windows.Forms.Button brCitire;
        private System.Windows.Forms.Button brSerializare;
        private System.Windows.Forms.Button btDeserializare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergereTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareTextToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervareNouaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareArboreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenareGraficToolStripMenuItem;
    }
}